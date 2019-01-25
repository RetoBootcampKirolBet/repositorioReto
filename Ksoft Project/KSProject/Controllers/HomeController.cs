using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using KSProject.Models;
using KSProject.Services;
using Microsoft.AspNetCore.Identity;
using KSProject.Data;
using Microsoft.AspNetCore.Authorization;
using Microsoft.EntityFrameworkCore;

namespace KSProject.Controllers
{
    [Authorize]
    public class HomeController : Controller
    {
        private readonly KSProjectServices _services;
        private readonly UserManager<KSUser> _userManager;
        private readonly ApplicationDbContext _context;

        public HomeController(KSProjectServices services, UserManager<KSUser> userManager, ApplicationDbContext context)
        {
            _services = services;
            _userManager = userManager;
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            //AppUser currentUser = await _userManager.GetUserAsync(User);
            //ViewBag.User = currentUser;
           
            if (User.Identity.IsAuthenticated)
            {
                if (User.HasClaim("admin", "admin"))
                {
                    return RedirectToAction("Configuration", "Home");
                }
                else if (User.HasClaim("teamleader", "teamleader"))
                {
                    return RedirectToAction("Members", "Home");
                }
                else if (User.HasClaim("developer", "developer"))
                {
                    return RedirectToAction("Members", "Home");
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

        public async Task<IActionResult> AsignarRole(int Id, string dropdown1)
        {
            await _services.AsignarRole(Id, dropdown1);
            return RedirectToAction(nameof(About));
        }

        public IActionResult AsignarTeam(int Id, string dropdown2)
        {
            _services.AsignarTeam(Id, dropdown2);
            return RedirectToAction(nameof(About));
        }

        public IActionResult About()
        {
            //ViewData["Message"] = "Your application description page.";
            return View();
        }

        public async Task<IActionResult> Contact()
        {
            //ViewData["Message"] = "Your application description page.";
            KSUser currentUser = await _userManager.GetUserAsync(User);
            User usuario = _context.User.Where(x => x.Login == currentUser.Email).FirstOrDefault();
            List<UserWorkPackage> workPackages = new List<UserWorkPackage>();

            //if (currentUser.Email == "administrador@gmail.com")
            if (User.HasClaim("admin", "admin"))
            {
                workPackages = await _context.UserWorkPackage
                .Include(x => x.WorkPackage)
                //.Include(x => x.UserWorkPackages.Select(t => t.User.Login == currentUser.Email))
                .Include(x => x.WorkPackage._Links)
                .Include(x => x.WorkPackage._Links.Status)
                .Include(x => x.WorkPackage._Links.Type)
                .Include(x => x.WorkPackage._Links.Priority)
                .Include(x => x.WorkPackage._Links.Assignee)
                .Include(x => x.WorkPackage.Description)
                .Include(x => x.WorkPackage._Links.CustomField1)
                .Include(x => x.WorkPackage._Links.CustomField2)
                .Include(x => x.WorkPackage._Links.Responsible)
                .Include(x => x.WorkPackage._Links.Author)
                //.Where(x => x.WorkPackage.User.Login == currentUser.Email)
                .ToListAsync();
            }
            else
            {
                workPackages = await _context.UserWorkPackage
                .Where(x => x.User.Login == currentUser.Email)
                .Include(x => x.WorkPackage)
                //.Include(x => x.UserWorkPackages.Select(t => t.User.Login == currentUser.Email))
                .Include(x => x.WorkPackage._Links)
                .Include(x => x.WorkPackage._Links.Status)
                .Include(x => x.WorkPackage._Links.Type)
                .Include(x => x.WorkPackage._Links.Priority)
                .Include(x => x.WorkPackage._Links.Assignee)
                .Include(x => x.WorkPackage.Description)
                .Include(x => x.WorkPackage._Links.CustomField1)
                .Include(x => x.WorkPackage._Links.CustomField2)
                .Include(x => x.WorkPackage._Links.Responsible)
                .Include(x => x.WorkPackage._Links.Author)
                //.Where(x => x.WorkPackage.User.Login == currentUser.Email)
                .ToListAsync();
            }

            return View(workPackages);
        }
        public async Task<IActionResult> Configuration()
        {
            //ViewData["Message"] = "Your application description page.";
            KSUser currentUser = await _userManager.GetUserAsync(User);
            User usuario = _context.User.Where(x => x.Login == currentUser.Email).FirstOrDefault();
            List<UserWorkPackage> workPackages = new List<UserWorkPackage>();

            //if (currentUser.Email == "administrador@gmail.com")
            if (User.HasClaim("admin", "admin"))
            {
                workPackages = await _context.UserWorkPackage
                .Include(x => x.WorkPackage)
                //.Include(x => x.UserWorkPackages.Select(t => t.User.Login == currentUser.Email))
                .Include(x => x.WorkPackage._Links)
                .Include(x => x.WorkPackage._Links.Status)
                .Include(x => x.WorkPackage._Links.Type)
                .Include(x => x.WorkPackage._Links.Priority)
                .Include(x => x.WorkPackage._Links.Assignee)
                .Include(x => x.WorkPackage.Description)
                .Include(x => x.WorkPackage._Links.CustomField1)
                .Include(x => x.WorkPackage._Links.CustomField2)
                .Include(x => x.WorkPackage._Links.Responsible)
                .Include(x => x.WorkPackage._Links.Author)
                //.Where(x => x.WorkPackage.User.Login == currentUser.Email)
                .ToListAsync();
            }
            else
            {
                workPackages = await _context.UserWorkPackage
                .Where(x => x.User.Login == currentUser.Email)
                .Include(x => x.WorkPackage)
                //.Include(x => x.UserWorkPackages.Select(t => t.User.Login == currentUser.Email))
                .Include(x => x.WorkPackage._Links)
                .Include(x => x.WorkPackage._Links.Status)
                .Include(x => x.WorkPackage._Links.Type)
                .Include(x => x.WorkPackage._Links.Priority)
                .Include(x => x.WorkPackage._Links.Assignee)
                .Include(x => x.WorkPackage.Description)
                .Include(x => x.WorkPackage._Links.CustomField1)
                .Include(x => x.WorkPackage._Links.CustomField2)
                .Include(x => x.WorkPackage._Links.Responsible)
                .Include(x => x.WorkPackage._Links.Author)
                //.Where(x => x.WorkPackage.User.Login == currentUser.Email)
                .ToListAsync();
            }

            return View(workPackages);
            //return View(await _context.WorkPackage.ToListAsync());
        }
        public IActionResult Members()
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
