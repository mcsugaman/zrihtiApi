using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Business.Abstract;
using Business.Implementation;
using DAL.Queries.Abstract.Test;
using DAL.Queries.Implementation.Test;
using Microsoft.IdentityModel.Tokens;
using System.Text;
using ZrihtiApi.Middleware.DataModels;
using ZrihtiApi.Middleware;
using Microsoft.Extensions.Options;
using DAL.Queries.Abstract.TPortalUser;
using DAL.Queries.Implementation.TPortalUser;

namespace ZrihtiApi
{
    public class Startup
    {
        /// <summary>
        /// BEARER Avtentikacija - parametri za šifriranje
        /// </summary>
        /// <param name="env"></param>
        private static readonly string secretKey = "zrihtiApiSecretKey11!22!33#";
        private static readonly string issure = "zrihtiApiCA";
        private static readonly string audience = "zrihtiApiCAAudience";



        public Startup(IHostingEnvironment env)
        {
            var builder = new ConfigurationBuilder()
                .SetBasePath(env.ContentRootPath)
                .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true)
                .AddJsonFile($"appsettings.{env.EnvironmentName}.json", optional: true)
                .AddEnvironmentVariables();
            Configuration = builder.Build();
        }

        public IConfigurationRoot Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            //CORS za Access-Control-Allow-Origin ce so requesti iz druge domene
            services.AddCors(options => options.AddPolicy("AllowAll", p => p.AllowAnyOrigin()
                                                                            .AllowAnyMethod()
                                                                            .AllowCredentials()
                                                                            .AllowAnyHeader()));

            // Add framework services.
            services.AddMvc();

            //Injectanje raznih INTERFACEOV (Dependency Injection)
            ///ZA Injectanje QUERY-jev vedno uporabis services.addTransient<> al pa servces.addScoped<>!!! za injectanje Biznisa pa services.addScoped<>////

            //Injectanje Businessov
            services.AddScoped<IFrontendBusiness, FrontendBusiness>();
            services.AddScoped<IAccountBusiness, AccountBusiness>();

            //Injectanje Querijev
            services.AddScoped<IGetProvidersQuery, GetProviderQuery>();
            services.AddScoped<IGetPortalUserByEmailQuery, GetPortalUserByEmailQuery>();
            services.AddScoped<IAddPortalUserQuery, AddPortalUserQuery>();
            services.AddScoped<IPortalUserConfirmMailQuery, PortalUserConfirmMailQuery>();
            //konec injectanja
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env, ILoggerFactory loggerFactory)
        {
            loggerFactory.AddConsole(Configuration.GetSection("Logging"));
            loggerFactory.AddDebug();
            app.UseDeveloperExceptionPage();//da nam izpise ERROR, to daš v produkciji ven !!

            //CORS 
            app.UseCors("AllowAll");

            //Bearer TOKEN
            //start jwt token config
            var signingKey = new SymmetricSecurityKey(Encoding.ASCII.GetBytes(secretKey));
            //generate token

            var jwtOptions = new TokenProviderOptions
            {
                Audience = audience,
                Issuer = issure,
                SigningCredentials = new SigningCredentials(signingKey, SecurityAlgorithms.HmacSha256)
            };

            app.UseMiddleware<TokenProviderMiddleware>(Options.Create(jwtOptions));

            //validation key


            var tokenValidationParameters = new TokenValidationParameters
            {
                //The signing key must match !
                ValidateIssuerSigningKey = true,
                IssuerSigningKey = signingKey,

                //Validate the JWT Issuer (iss) claim
                ValidateIssuer = true,
                ValidIssuer = issure,

                //validate the JWT Audience (aud) claim

                ValidateAudience = true,
                ValidAudience = audience,

                //validate the token expiry
                ValidateLifetime = true,

                // If you  want to allow a certain amout of clock drift
                ClockSkew = TimeSpan.Zero
            };


            //konec Bearer TOKEN

            //Uporabimo Bearer Jwt Avtentikacijo
            app.UseJwtBearerAuthentication(new JwtBearerOptions
            {
                AutomaticAuthenticate = false,
                AutomaticChallenge = true,
                TokenValidationParameters = tokenValidationParameters,
                AuthenticationScheme = "Bearer"
            });


            //app.UseMvc();

            app.UseMvc(routes =>
            {
                routes.MapRoute("default", "{controller=Home}/{action=Index}/{id?}");
            });

            

        }
    }
}
