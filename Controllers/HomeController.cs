using MeuSiteEmMVC.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace MeuSiteEmMVC.Controllers
{
    public class HomeController : Controller
    {
       
        public IActionResult Index()
        {
            HomeModel home = new();

            home.Nome = "Paulo Fabricio";
            home.Email = "paulofsm95@gmail.com";
            home.Desenvolvedor = "Sou o Mais novo Desenvolvedor C#";

            return View(home);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
