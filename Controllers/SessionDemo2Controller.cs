using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace Session.Controllers
{
    public class SessionDemo2Controller : Controller
    {
        public IActionResult Index()
        {

            var UserName = JsonConvert.DeserializeObject<string>(HttpContext.Session.GetString("UserName"));

            HttpContext.Session.Clear();

            ViewBag.Name = UserName;
     

            return View();
        }
    }
}