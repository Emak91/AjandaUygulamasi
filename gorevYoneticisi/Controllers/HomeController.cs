using gorevYoneticisi.Entities;
using gorevYoneticisi.Model;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace gorevYoneticisi.Controllers
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
            var eventlar = db.Events.Select(a => new ListEventsDTO
            {
                title = a.tittle,
                start = a.start,
                end = a.end,
                allDay = "",
                color = a.color,
                textColor = a.textColor,
                Id = a.id

            }).ToList();
            //var eventlar2 = eventlar.Select(a => new ListEventsDTO
            //{
            //    title = a.tittle,
            //    start = a.start,
            //    end = a.end,
            //    allDay = "",
            //    color = a.color,
            //    textColor = a.textColor,
            //    Id = a.id

            //});
            return new JsonResult(eventlar);
        }

        public JsonResult AddNewEvent(string title,string start, string end)
        {
            
            Event ev = new Event();
            ev.tittle = title;
            ev.start = Convert.ToDateTime(start);
            ev.end = Convert.ToDateTime(end);

            AppDbContext db = new AppDbContext();
            db.Events.Add(ev);
            db.SaveChanges();

            return Json("OK");
        }

        public JsonResult RemoveEvent(string ID)
        {
            if (!string.IsNullOrEmpty(ID))
            {
                int id = int.Parse(ID);
                AppDbContext db = new AppDbContext();
                var getEvent = db.Events.Find(id);
                db.Events.Remove(getEvent);
                db.SaveChanges();
                return Json("OK");
            }
            return Json("Silinecek Kayıt Bulunamadı");
        }

    }
}

