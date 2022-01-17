using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;


namespace projectC.Controllers
{
    public class HeroisController : Controller {
        //Get Herois
        public IActionResult Index(){
            return View();
        }
    }
}