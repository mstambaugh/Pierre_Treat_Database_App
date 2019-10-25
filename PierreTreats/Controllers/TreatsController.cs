using Microsoft.AspNetCore.Mvc;
using PierreTreats.Models;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace PierreTreats.Controllers
{
    public class TreatsController : Controller
    {
        private readonly PierreTreatsContext _db;

        public TreatsController(PierreTreatsContext db)
        {
            _db = db;
        }
        public ActionResult Index()
        {
            List<Treat> model = _db.Treats.ToList();
            return View(model);
        }
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(Treat treat)
        {
            _db.Treats.Add(treat);
            _db.SaveChanges();
            return RedirectToAction("Index");
        }
    }

}