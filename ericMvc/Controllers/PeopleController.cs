using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ericMvc.Models;

namespace ericMvc.Controllers
{
    

        public class PeopleController : Controller
        {

          
            public IActionResult Index()
            {
                List<PeopleModel> people = new List<PeopleModel>();
                people.Add(new PeopleModel { FirstName = "Eric", LastName = "Taft", Age = "30" });
                people.Add(new PeopleModel { FirstName = "andrew", LastName = "gallowitch", Age = "35" });
                people.Add(new PeopleModel { FirstName = "nicole", LastName = "gander", Age = "32" });
                people.Add(new PeopleModel { FirstName = "lisa", LastName = "barry", Age = "35" });
                people.Add(new PeopleModel { FirstName = "jerry", LastName = "johnson", Age = "36" });
         
            
                   
                          return View(people);
            }
                public IActionResult Coffee()
            {
                List<Coffee> Coffee = new List<Coffee>();
              Coffee.Add(new Coffee { Brand = "Eric", Name = "Taft", Origin = "30" });
              Coffee.Add(new Coffee { Brand = "andrew", Name = "gallowitch", Origin = "35" });
              Coffee.Add(new Coffee { Brand = "nicole", Name = "gander", Origin = "32" });
              Coffee.Add(new Coffee { Brand = "lisa", Name = "barry", Origin = "35" });
              Coffee.Add(new Coffee { Brand = "jerry", Name = "johnson", Origin = "36" });
         
            
                   
                          return View(Coffee);
            }

  [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        }

    
}

