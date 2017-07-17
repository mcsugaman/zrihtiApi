using Business.Abstract;
using DAL.Entities;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace ZrihtiApi.Controllers
{
    public class FrontApiController: Controller
    {
        private readonly IFrontendBusiness _frontendBusiness;

        public FrontApiController (IFrontendBusiness frontendBusiness)
        {
            _frontendBusiness = frontendBusiness;
        }


        public string getPlace()
        {
            return _frontendBusiness.test().Name;
        }
        

    
    }
}
