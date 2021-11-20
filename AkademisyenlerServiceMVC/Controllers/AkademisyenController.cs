using AkademisyenlerServiceMVC.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AkademisyenlerServiceMVC.Controllers
{
    public class AkademisyenController : Controller
    {
        private readonly DatabaseContext _context;

        public AkademisyenController(DatabaseContext context)
        {
            _context = context;
        }

        public IActionResult Index2()
        {
            
            return View();
        }

        public IActionResult Login()
        {
            return View();
        }
        public ActionResult Index()
        {
            List<Ogrenci> ogrenciler = new List<Ogrenci>();

            ogrenciler = _context.Ogrenciler.ToList();

            return View(ogrenciler);
        }

        public async Task<IActionResult> Detaylar(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var ogrenci = await _context.Ogrenciler
                .Include(o => o.Bolum)
                .FirstOrDefaultAsync(m => m.OgrenciId == id);
            if (ogrenci == null)
            {
                return NotFound();
            }
            
            return View(ogrenci);
        }

        [HttpGet]
        public async Task<IActionResult> Duzenle(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var ogrenci = await _context.Ogrenciler.FindAsync(id);

            if (ogrenci == null)
            {
                return NotFound();
            }

            ViewData["BolumId"] = new SelectList(_context.Bolumler, "BolumId", "BolumId", ogrenci.BolumId);

            return View(ogrenci);
        }

        [HttpPost]
        public async Task<IActionResult> Duzenle(int? id, [Bind("OgrenciId,Adi,SoyAdi,Email,Sifre,Token,BolumId,StajBasvuruDurumu")] Ogrenci ogrenci)
        {
            var guncelle_ogrenci = _context.Ogrenciler.Find(ogrenci.OgrenciId);
            
            if (ogrenci == null)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    guncelle_ogrenci.StajBasvuruDurumu = ogrenci.StajBasvuruDurumu;
                    //_context.Update(ogrenci);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!OgrenciExists(ogrenci.OgrenciId))
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
            ViewData["BolumId"] = new SelectList(_context.Bolumler, "BolumId", "BolumId", ogrenci.BolumId);
            return View(ogrenci);

        }

        private bool OgrenciExists(int id)
        {
            return _context.Ogrenciler.Any(e => e.OgrenciId == id);
        }
    }
}
