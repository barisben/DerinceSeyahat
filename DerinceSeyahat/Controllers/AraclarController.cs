using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using DerinceSeyahat.Data;
using DerinceSeyahat.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using System.IO;

namespace DerinceSeyahat.Controllers
{
    [Authorize(Roles="Admin")]
    public class AraclarController : Controller
    {
        private readonly ApplicationDbContext _context;

        private readonly IWebHostEnvironment _hostingEnvironment;
        public AraclarController(ApplicationDbContext context, IWebHostEnvironment hostingEnvironment)
        {
            _context = context;
            _hostingEnvironment = hostingEnvironment;
        }

        // GET: Araclar
        public async Task<IActionResult> Index()
        {
            return View(await _context.Araclar.ToListAsync());
        }

        // GET: Araclar/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var arac = await _context.Araclar
                .FirstOrDefaultAsync(m => m.AracId == id);
            if (arac == null)
            {
                return NotFound();
            }

            return View(arac);
        }

        // GET: Araclar/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Araclar/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("AracId,AracMarka,AracModel,AracKapasite,AracAdet,AracImage")] Arac arac)
        {
            if (ModelState.IsValid)
            {
                string webRootPath = _hostingEnvironment.WebRootPath;
                var files = HttpContext.Request.Form.Files;


                string fileName = Guid.NewGuid().ToString();
                var uploads = Path.Combine(webRootPath, @"img\araclar");
                var extension = Path.GetExtension(files[0].FileName);

                using (var fileStream = new FileStream(Path.Combine(uploads, fileName + extension), FileMode.Create))
                {
                    files[0].CopyTo(fileStream);
                }
                arac.AracImage = @"\img\araclar\" + fileName + extension;

                _context.Add(arac);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(arac);
        }

        // GET: Araclar/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var arac = await _context.Araclar.FindAsync(id);
            if (arac == null)
            {
                return NotFound();
            }
            return View(arac);
        }

        // POST: Araclar/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("AracId,AracMarka,AracModel,AracKapasite,AracAdet,AracImage")] Arac arac)
        {
            if (id != arac.AracId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    string webRootPath = _hostingEnvironment.WebRootPath;
                    var files = HttpContext.Request.Form.Files;


                    string fileName = Guid.NewGuid().ToString();
                    var uploads = Path.Combine(webRootPath, @"img\araclar");
                    var extension = Path.GetExtension(files[0].FileName);

                    using (var fileStream = new FileStream(Path.Combine(uploads, fileName + extension), FileMode.Create))
                    {
                        files[0].CopyTo(fileStream);
                    }
                    arac.AracImage = @"\img\araclar\" + fileName + extension;

                    _context.Update(arac);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!AracExists(arac.AracId))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(arac);
        }

        // GET: Araclar/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var arac = await _context.Araclar
                .FirstOrDefaultAsync(m => m.AracId == id);
            if (arac == null)
            {
                return NotFound();
            }

            return View(arac);
        }

        // POST: Araclar/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var arac = await _context.Araclar.FindAsync(id);
            _context.Araclar.Remove(arac);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool AracExists(int id)
        {
            return _context.Araclar.Any(e => e.AracId == id);
        }
    }
}
