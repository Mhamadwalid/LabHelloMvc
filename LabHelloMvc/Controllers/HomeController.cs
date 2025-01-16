using System.Security.Cryptography.X509Certificates;
using LabHelloMvc.Models;
using Microsoft.AspNetCore.Mvc;

namespace LabHelloMvc.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {

            
                var person = new Person
                {
                    FirstName = "Mhamad",
                    LastName = "Al Nasaan"
                };
                return View(person);
            
        }
    }
}

