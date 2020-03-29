using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Session.Models;

namespace Session.Controllers
{
    public class SessionDemo1Controller : Controller
    {
        public string  UserName { get; set; }
        public IActionResult Index()
        {
            UserName = "Vinit Suryarao";

            var UserNameJson = JsonConvert.SerializeObject(UserName);

            HttpContext.Session.SetString("UserName", UserNameJson);

            return View("Index", "SessionDemo2");
        }
    }
}