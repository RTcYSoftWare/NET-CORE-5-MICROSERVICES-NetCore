using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using OgrenciMvc.Database;
using OgrenciMvc.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OgrenciMvc.Controllers
{
    public class AkademisyenlerController : Controller
    {
        private readonly DatabaseContext _context;

        public AkademisyenlerController(DatabaseContext context)
        {
            _context = context;
        }

        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public JsonResult Login(string mail, string sifre)
        {
            string sonuc = "0";

            string kont_mail = "deneme@ktun.edu.tr";
            string kont_sifre = "123456";

            if (mail != null && sifre != null)
            {
                if (kont_mail.Equals(mail) && kont_sifre.Equals(sifre))
                {
                    sonuc = "1";
                }
                else
                {
                    sonuc = "2";
                }
            }
            else
            {
                sonuc = "3";
            }

            return Json(sonuc);
        }


        public IActionResult Index()
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

        public IActionResult Yeni()
        {
            return View();
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

        public IActionResult SoruCevap()
        {
            List<Ogrenci> ogrenciler = new List<Ogrenci>();
            ogrenciler = _context.Ogrenciler.ToList();


            return View(ogrenciler);
        }

        public IActionResult CevapEkle(int id)
        {
            Ogrenci ogrenci = new Ogrenci();

            //ogrenci = (from v in _context.Ogrenciler
            //           where v.OgrenciId == id
            //           select v).FirstOrDefault();

            ogrenci = _context.Ogrenciler.Where(x => x.OgrenciId == id).FirstOrDefault();



            return View(ogrenci);
        }


        public JsonResult CevapKaydet(int id, string cevap)
        {
            Ogrenci cevap_ekle = new Ogrenci();

            cevap_ekle = _context.Ogrenciler.Where(x => x.OgrenciId == id).FirstOrDefault();

            string sonuc = "0";

            if (id > 0 && cevap != null)
            {
                cevap_ekle.Cevap1 = cevap;

                _context.SaveChanges();
                sonuc = "1";
            }
            else
            {
                sonuc = "2";
            }



            return Json(sonuc);
        }

        public IActionResult StajDurum()
        {
            List<Ogrenci> ogrenciler = new List<Ogrenci>();

            ogrenciler = _context.Ogrenciler.ToList();


            return View(ogrenciler);
        }


        public IActionResult PuanGor(int id)
        {
            Ogrenci ogr = new Ogrenci();

            if (id != 0)
            {
                ogr = (from o in _context.Ogrenciler
                       where o.OgrenciId == id
                       select o).FirstOrDefault();
            }


            return View(ogr);
        }



        private bool OgrenciExists(int ogrenciId)
        {
            throw new NotImplementedException();
        }
    }
}
