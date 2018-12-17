using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using AppRetoKirolBet.Models;
using System.Net.Http;
using System.Net.Http.Headers;
using Newtonsoft.Json;
using System.Net;
using System.Text;
using AppRetoKirolBet.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using AppRetoKirolBet.Data;

namespace AppRetoKirolBet.Controllers
{
    [Authorize]
    public class HomeController : Controller
    {
        private readonly KirolBetServices _services;
        private readonly UserManager<IdentityUser> _userManager;
        private readonly ApplicationDbContext _context;

        public HomeController(KirolBetServices services, UserManager<IdentityUser> userManager, ApplicationDbContext context)
        {
            _services = services;
            _userManager = userManager;
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            if (User.Identity.IsAuthenticated)
            {
                if (User.HasClaim("admin", "admin"))
                {
                    return RedirectToAction("Contact", "Home");
                }
                else if (User.HasClaim("teamleader", "teamleader"))
                {
                    return RedirectToAction("Index", "Home");
                }
                else if (User.HasClaim("developer", "developer"))
                {
                    return RedirectToAction("About", "Home");
                }
            }
            await _services.InsertUserInBD();
            await _services.InsertWPInBD();
            return View(User);
        }

        public IActionResult Activate(int id)
        {
            _services.ActivateWPBD(id);
            return RedirectToAction(nameof(Contact));
        }

        public IActionResult Inactivate(int id)
        {
            _services.InactivateWPBD(id);
            return RedirectToAction(nameof(Contact));
        }

        //public IActionResult DesignActivaty()
        //{
        //    _services.DesignActivBD();
        //    return RedirectToAction(nameof(Contact));
        //}

        public IActionResult Asignar(int Id, string dropdown1, string dropdown2)
        {
            _services.Asignar(Id, dropdown1, dropdown2);
            return RedirectToAction(nameof(About));
        }

        public async Task<IActionResult> About()
        {
            //ViewData["Message"] = "Your application description page.";
            IdentityUser currentUser = await _userManager.GetUserAsync(User);
            User usuario = _context.User.Where(x => x.Login == currentUser.Email).FirstOrDefault();
            return View();
        }

        public IActionResult Contact()
        {
            //ViewData["Message"] = "Your application description page.";
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
