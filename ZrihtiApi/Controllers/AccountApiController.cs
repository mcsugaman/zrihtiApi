using Business.Abstract;
using MailKit.Net.Smtp;
using MailKit.Security;
using Microsoft.AspNetCore.Mvc;
using MimeKit;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace ZrihtiApi.Controllers
{
    public class AccountApiController: Controller
    {
        private readonly IAccountBusiness _accountBusiness;

        public AccountApiController(IAccountBusiness accountBusiness)
        {
            _accountBusiness = accountBusiness;
        }
        

        [HttpPost]
        public string registerNewUser(string email, string username, string password)
        {
            return _accountBusiness.registerNewUser(email, username, password);
            
        }

        [HttpPost]
        public string confirmMail(string email, string hash)
        {
            return _accountBusiness.confirmMail(email, hash);

        }
    }
}
