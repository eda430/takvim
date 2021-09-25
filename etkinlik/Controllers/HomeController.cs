using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using etkinlik.Entities;
using Newtonsoft.Json;

namespace etkinlik.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult tumEtkinlikleriGetir()
        {
            AppDbContext db = new AppDbContext();
            var eventlar = db.Events.ToList();

            return new JsonResult(eventlar);

        }
    }
}
