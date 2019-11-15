using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MCVDemo.Models;

namespace MCVDemo.Controllers
{
    public class PeopleController : Controller
    {
        // GET: People
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult ListPeople()
        {
            PersonModel p = new PersonModel();
            int i = 5 / p.Age;

            List<PersonModel> people = new List<PersonModel>
            {
                new PersonModel { FirstName = "SB", LastName = "Lu", Age = 25 },
                new PersonModel { FirstName = "Coco", LastName = "Li", Age = 23 },
                new PersonModel { FirstName = "Zozo", LastName = "Liu", Age = 28 }
            };

            return View(people);
        }
    }
}