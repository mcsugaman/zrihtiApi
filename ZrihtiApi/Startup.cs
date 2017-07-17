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

namespace ZrihtiApi
{
    public class Startup
    {
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
            // Add framework services.
            services.AddMvc();

            //Injectanje raznih INTERFACEOV (Dependency Injection)
            ///ZA Injectanje QUERY-jev vedno uporabis services.addTransient<> al pa servces.addScoped<>!!! za injectanje Biznisa pa services.addScoped<>////

            //Injectanje Businessov
            services.AddScoped<IFrontendBusiness, FrontendBusiness>();

            //Injectanje Querijev
            services.AddScoped<IGetProvidersQuery, GetProviderQuery>();
            //konec injectanja
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env, ILoggerFactory loggerFactory)
        {
            loggerFactory.AddConsole(Configuration.GetSection("Logging"));
            loggerFactory.AddDebug();
            app.UseDeveloperExceptionPage();//da nam izpise ERROR, to daš v produkciji ven !!


            app.UseMvc();
            app.UseMvc(routes =>
            {
                routes.MapRoute("default", "{controller=Home}/{action=Index}/{id?}");
            });
            
        }
    }
}
