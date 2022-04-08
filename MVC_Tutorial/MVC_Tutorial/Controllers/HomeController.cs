using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.IO;
using MVC_Tutorial.Models;

namespace MVC_Tutorial.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ///THIS LOGS TO A TEXT DOCUMENT EVERYTIME A USER VISITS CONTROLLER INDEX. IT WILL WRITE HELLO
            //string text = "Hello";
            //System.IO.File.WriteAllText(@"C:\Users\Laptop\Documents\GitHub\MVC\MVC_Tutorial\MVC_Tutorial\Log.txt", text);

            /// THIS GETS A RANDOM NUMBER THEN ASSIGNS THAT RANDOM NUMBER A VAR NAME OF NUM
            /// THEN WE USE THE VIEWBAG AND TO ASSIGN VAR NUM TO IT. 
            //Random rnd = new Random(10);
            //var num = rnd.Next();
            //ViewBag.RandomNumber = num;

            ///// THIS SAYS IF THE VAR NUM IS GREATER THEN 2000 RETURN VIEW AND THE STRING THAT WILL BE SHOWN ABOUT 
            //if (num > 2000)
            //{
            //    return View("About");
            //}

            //List<string> names = new List<string>
            //{
            //    "Jesse",
            //    "Adam",
            //    "Brett"
            //};

            User user = new User();
            user.ID = 1;
            user.FirstName = "Evan";
            user.LastName = "Masters";
            user.Age = 24;


            return View(user);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}