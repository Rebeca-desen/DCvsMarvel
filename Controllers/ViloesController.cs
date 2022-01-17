using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;


namespace projectC.Controllers
{
    public class ViloesController : Controller {
        //Get Viloes
        public IActionResult Index(){
            return View();
        }
    }
}