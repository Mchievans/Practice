using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using EntityFrameWork.Models;

namespace EntityFrameWork.Controllers
{
    public class HomeController : Controller
    {
        private IMbox matchbox;
        private Matchbox mbox;
        private ILbox lunchbox;
        private Lunchbox lbox;

        public ViewResult Index()
        {
            return View();
        }

        public ViewResult Lunch()
        {
            return View(lunchbox.Lunchboxes);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddLunchBox(Lunchbox L)
        {
            lunchbox.SaveLunchbox(L);
            return RedirectToAction("Index");
        }

        [HttpPost]
        public IActionResult AddMatchBox(Matchbox M)
        {
            matchbox.SaveMatchbox(M);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult AllMatchboxes(Matchbox M)
        {
            matchbox.SaveMatchbox(M);
            return RedirectToAction("Index");
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
