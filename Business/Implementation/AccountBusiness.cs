using Business.Abstract;
using DAL.Entities;
using DAL.Queries.Abstract.Test;
using DAL.Queries.Abstract.TPortalUser;
using MailKit.Net.Smtp;
using Microsoft.AspNetCore.Http;
using MimeKit;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Implementation
{
    public class AccountBusiness : IAccountBusiness
    {
        //from address
        private readonly string FromAddress = "Zrihti@gmail.com";
        private readonly string FromAddressPassword = "zrihtisi15toritev";
        private readonly string FromAddressTitle = "Zrihti.si";

        //smtp server
        private readonly string SmtpServer = "smtp.gmail.com";

        //smtp port number
        private readonly int SmtpPortNumber = 587;

        //url Naslov aplikacije, spremeni pred produkcijo
        private readonly string hostUrl = "localhost:4200/";  //NASLOV od ANGULAR Aplikacije


        //deklaracija QUERY-jev
        private readonly IGetProvidersQuery _getProviderQuery;
        private readonly IGetPortalUserByEmailQuery _getPortalUserByEmailQuery;
        private readonly IAddPortalUserQuery _addPortalUserQuery;
        private readonly IPortalUserConfirmMailQuery _portalUserConfirmMailQuery;

        public AccountBusiness(IGetProvidersQuery getProvidersQuery,
                                IGetPortalUserByEmailQuery getPortalUserByEmailQuery,
                                IAddPortalUserQuery addPortalUserQuery,
                                IPortalUserConfirmMailQuery portalUserConfirmMailQuery)
        {
            _getProviderQuery = getProvidersQuery;
            _getPortalUserByEmailQuery = getPortalUserByEmailQuery;
            _addPortalUserQuery = addPortalUserQuery;
            _portalUserConfirmMailQuery = portalUserConfirmMailQuery;
        }


        //Deklaracija funkcij za Account
        public string registerNewUser(string email, string username, string password)
        {
            PortalUser pUser = _getPortalUserByEmailQuery.execute(email);

            //če user s tem emailom ne obstaja, vpišemo novega userja v bazo , vrnemo success in pošljemo potrditveni mail
            if(pUser == null)
            {
                PortalUser newPortalUser = new PortalUser();
                newPortalUser.Username = username;
                newPortalUser.Password = password;
                newPortalUser.LoginId = email;
                newPortalUser.ConfirmationHash = Guid.NewGuid().ToString();
                newPortalUser.Confirmed = false;
                newPortalUser.DateCreated = DateTime.Now;
                newPortalUser.IdRole = 2;

                _addPortalUserQuery.execute(newPortalUser);

                
                //toAddress
                string ToAddress = email;
                string ToAddressTitle = "Potrditvena povezava za nov račun";
                string Subject = "Potrditvena povezava za nov račun na zrihti.si";
                string BodyContent = "<h1>Potrditveno sporočilo</h1><br /><br /><p>Pozdravljeni, " + newPortalUser.Username + "." + "</p><br /><br />" +
                                    "<p>Poslali smo vam potrditveno sporočilo, zato s klikom na</p><a href='http://" + hostUrl + "confirmMail/" + newPortalUser.LoginId + "/" +  newPortalUser.ConfirmationHash + 
                                    "'>POTRDITEV</a> potrdite svoj elektronski naslov.";

                var mimeMessage = new MimeMessage();
                mimeMessage.From.Add(new MailboxAddress(FromAddressTitle, FromAddress));
                mimeMessage.To.Add(new MailboxAddress(ToAddressTitle, ToAddress));
                mimeMessage.Subject = Subject;

                var bodyBuilder = new BodyBuilder();
                bodyBuilder.HtmlBody = BodyContent;

                mimeMessage.Body = bodyBuilder.ToMessageBody();

                try
                {
                    using (var client = new SmtpClient())
                    {
                        client.Connect(SmtpServer, SmtpPortNumber, false);
                        //potrebno samo ce SMTP server zahteva avtentikacijo
                        //Error 5.5.1 Authentication
                        client.Authenticate(FromAddress, FromAddressPassword);
                        client.Send(mimeMessage);
                        Console.WriteLine("Email za registracijo poslan na naslov " + ToAddress + " !");
                        client.Disconnect(true);
                        return "Success1";
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine("Prišlo je do napake pri pošiljanju potrditvenega maila !!! :" + e.Message);
                    return "Error2";
                }


                
            }



            //če pa user že obstaja, pa vrnemo napako
            else
            {
                return "Error1";
            }

            
        }//registerNewUser
    


        public string confirmMail(string email, string hash)
        {
            return _portalUserConfirmMailQuery.execute(email, hash);
        }
    }
}
