using DerinceSeyahat.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DerinceSeyahat.Controllers
{
    public class FiloController : Controller
    {
        private readonly ApplicationDbContext db;

        public FiloController(ApplicationDbContext _db)
        {
            db = _db;
        }

        public IActionResult Index()
        {
            return View(db.Araclar.ToList());
        }

        public IActionResult Arac(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var arac = db.Araclar.FirstOrDefault(x => x.AracId == id);
            if (arac == null)
            {
                return NotFound();
            }

            return View(arac);
        }
    }
}
