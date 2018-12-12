using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using AppRetoKitolBet.Models;
using System.Net.Http;
using System.Net.Http.Headers;
using Newtonsoft.Json;
using System.Net;
using System.Text;
using AppRetoKitolBet.Services;
using Microsoft.AspNetCore.Authorization;

namespace AppRetoKitolBet.Controllers
{
    [Authorize]
    public class HomeController : Controller
    {
        private readonly KirolBetServices _services;

        public HomeController(KirolBetServices services)
        {
            _services = services;
        }

        public async Task<IActionResult> Index()
        {
            //await _services.InsertWPInBD();
            return View(User);
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";
            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your application description page.";
            return View();
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
