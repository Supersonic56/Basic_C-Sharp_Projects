using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using StudentsMVC_drill.Models;


namespace StudentsMVC_drill.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page. Contact us.";

            return View();
        }

        public ActionResult Instructor(int id)
        {
            ViewBag.Id = id;

            Instructor dayTimeInstructor = new Instructor
            {
                Id = 1,
                FirstName = "Erik",
                LastName = "Gross"
            };

            return View(dayTimeInstructor);
        }
        
        public ActionResult Instructors()
        {
            List<Instructor> instructors = new List<Instructor>
           {
               new Instructor
               {
                   Id = 1,
                   FirstName = "Rick",
                   LastName = "Ramen"
               },
               new Instructor
               {
                   Id = 2,
                   FirstName = "Brett",
                   LastName = "Calen"
               },
               new Instructor
               {
                   Id = 3,
                   FirstName = "Adam",
                   LastName = "Smith"
               },
           };

           return View(instructors);
        }
        

    }
}