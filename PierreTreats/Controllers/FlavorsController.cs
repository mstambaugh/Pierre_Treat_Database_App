using Microsoft.AspNetCore.Mvc;
using PierreTreats.Models;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using System.Threading.Tasks;
using System.Security.Claims;

namespace PierreTreats.Controllers
{
    [Authorize]
    public class FlavorsController : Controller
    {
        private readonly PierreTreatsContext _db;
        private readonly UserManager<ApplicationUser> _userManager;
        public FlavorsController(UserManager<ApplicationUser> userManager, PierreTreatsContext db)
        {
            _userManager = userManager;
            _db = db;
        }
        public async Task<ActionResult> Index()
        {
            var userId = this.User.FindFirst(ClaimTypes.NameIdentifier)?.Value;
            var currentUser = await _userManager.FindByIdAsync(userId);
            var userFlavors = _db.Flavors.Where(entry => entry.User.Id == currentUser.Id);
            return View(userFlavors);
        }
        public ActionResult Create()
        {
            ViewBag.TreatId = new SelectList(_db.Treats, "TreatId", "TreatType");
            return View();
        }
        [HttpPost]
        public async Task<ActionResult> Create(Flavor flavor, int TreatId)
        {
            var userId = this.User.FindFirst(ClaimTypes.NameIdentifier)?.Value;
            var currentUser = await _userManager.FindByIdAsync(userId);
            flavor.User = currentUser;
            _db.Flavors.Add(flavor);
            if (TreatId != 0)
            {
                _db.FlavorTreat.Add(new FlavorTreat() { TreatId = TreatId, FlavorId = flavor.FlavorId });
            }
            _db.SaveChanges();
            return RedirectToAction("Index");
        }
    }

}