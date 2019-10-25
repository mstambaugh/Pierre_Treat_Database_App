using Microsoft.AspNetCore.Mvc;
using PierreTreats.Models;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc.Rendering;
// using Microsoft.AspNetCore.Authorization;
// using Microsoft.AspNetCore.Identity;
using System.Threading.Tasks;
// using System.Security.Claims;

namespace PierreTreats.Controllers
{
    public class FlavorsController : Controller
    {
        private readonly PierreTreatsContext _db;
        public FlavorsController(PierreTreatsContext db)
        {
            _db = _db;
        }
        public ActionResult Index()
        {
            return View(_db.Flavors.ToList());
        }
        
    }

}