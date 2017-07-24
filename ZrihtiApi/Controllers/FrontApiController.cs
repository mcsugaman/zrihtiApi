using Business.Abstract;
using DAL.Entities;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Authorization;

namespace ZrihtiApi.Controllers
{
    
    public class FrontApiController: Controller
    {
        private readonly IFrontendBusiness _frontendBusiness;

        public FrontApiController (IFrontendBusiness frontendBusiness)
        {
            _frontendBusiness = frontendBusiness;
        }

        [HttpPost]
        [Authorize(ActiveAuthenticationSchemes = "Bearer")]
        public string getPlace()
        {
            //na tak nacin dobimo CLAIME iz JWT Tokena, ki ga user poslje, v tem primeru dobimo ROLO, lahko pa dobimo se username in ostale podatke, ki so zapisani v Claimih od TOKEN-a
            return HttpContext.User.Claims.Where(x => x.Type == "http://schemas.xmlsoap.org/ws/2005/05/identity/claims/givenname").FirstOrDefault().Value.ToString(); 
        }
        

    
    }
}
