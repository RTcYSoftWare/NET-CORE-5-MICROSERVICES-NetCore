using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using OgrenciMvc.Database;
using OgrenciMvc.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace OgrenciMvc.Controllers
{
    //[Authorize()]
    public class Ogrenciler : Controller
    {
        private readonly DatabaseContext _context;
        public Ogrenciler(DatabaseContext context)
        {
            _context = context;
        }

        public ActionResult Anasayfa(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var ogrenci = _context.Ogrenciler.Find(id);

            if (ogrenci == null)
            {
                return NotFound();
            }
            ViewBag.Id = ogrenci.OgrenciId;

            return View(ogrenci);
        }
        [AllowAnonymous]
        public IActionResult Login()
        {
            return View();
        }

        [HttpGet]
        public ActionResult StajBasvurusu(int id)
        {
            ViewBag.Id = id;

            var ogrenci = _context.Ogrenciler.Find(id);
            return View(ogrenci);
        }
        [HttpPost]
        public ActionResult StajBasvurusu(IEnumerable<IFormFile> files)
        {

            var ogrenci = _context.Ogrenciler.Find(7);
            int dosya_numarasi = 0;
            foreach (var file in files)
            {
                if (file != null)
                {
                    string uzanti = Path.GetExtension(file.FileName);
                    string dosya_adi = file.FileName;
                    //string dosya_adi = Guid.NewGuid() + uzanti;
                    string yol = Path.Combine(Directory.GetCurrentDirectory(), $"wwwroot/image/{dosya_adi}");
                    //string yol = Path.Combine(Directory.GetCurrentDirectory(), $"Image/{dosya_adi}");
                    string sql_yol = "/image/" + dosya_adi;
                    using var stream = new FileStream(yol, FileMode.Create);

                    file.CopyToAsync(stream);
                    
                    if(dosya_numarasi == 0)
                    {
                        ogrenci.StajBasvuruFormu = sql_yol;
                        dosya_numarasi++;
                    }                        
                    else if(dosya_numarasi == 1)
                    {
                        ogrenci.StajSaglikFormu = sql_yol;
                        dosya_numarasi++;
                    }                        
                    else if(dosya_numarasi == 2)
                    {
                        ogrenci.StajUcertFormu = sql_yol;
                        dosya_numarasi++;
                    }                      
                }
            }
            _context.SaveChanges();
            dosya_numarasi = 0;
            return RedirectToAction("StajBasvurusu");
        }


        public IActionResult SoruCevap(int id)
        {
            ViewBag.Id = id;
            return View();
        }


        public JsonResult SoruEkle(int id, string soru)
        {
            string sonuc = "0";

            Ogrenci soru_kaydet = new Ogrenci();


            if (id != 0 && soru != null)
            {
                soru_kaydet = (from s in _context.Ogrenciler
                               where s.OgrenciId == id
                               select s).FirstOrDefault();

                if (soru_kaydet != null)
                {
                    soru_kaydet.Soru1 = soru;
                    
                    _context.SaveChanges();
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


        public IActionResult StajDurumu(int id)
        {
            Ogrenci ogrenci = new Ogrenci();

            ogrenci = (from o in _context.Ogrenciler
                       where o.OgrenciId == id
                       select o).FirstOrDefault();

            int gun = ogrenci.StajGunu;

            ViewBag.Gun = gun + 1;
            ViewBag.Id = id;

            return View(ogrenci);
        }


        public JsonResult GunKaydet(int id, string gun, int gun_numarasi)
        {
            string sonuc = "0";

            Ogrenci gun_kaydet = new Ogrenci();


            if (id != 0 && gun != null && gun_numarasi != 0)
            {
                gun_kaydet = (from g in _context.Ogrenciler
                              where g.OgrenciId == id
                              select g).FirstOrDefault();

                if (gun_kaydet != null)
                {
                    if (gun_numarasi == 1)
                    {
                        gun_kaydet.StajGun1 = gun;
                        gun_kaydet.StajGunu += 1;
                        _context.SaveChanges();
                        sonuc = "1";
                    }
                    else if (gun_numarasi == 2)
                    {
                        gun_kaydet.StajGun2 = gun;
                        gun_kaydet.StajGunu += 1;
                        _context.SaveChanges();
                        sonuc = "1";
                    }
                    else if (gun_numarasi == 3)
                    {
                        gun_kaydet.StajGun3 = gun;
                        gun_kaydet.StajGunu += 1;
                        _context.SaveChanges();
                        sonuc = "1";
                    }
                    else
                    {
                        sonuc = "4";
                    }
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




    }
}
