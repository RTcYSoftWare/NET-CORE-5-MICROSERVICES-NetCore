using Microsoft.AspNetCore.Mvc;
using OgrenciMvc.Database;
using OgrenciMvc.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OgrenciMvc.Controllers
{
    public class StajSefController : Controller
    {
        private readonly DatabaseContext _context;

        public StajSefController(DatabaseContext context)
        {
            _context = context;
        }

        public IActionResult Login()
        {
            return View();
        }

        public IActionResult Index()
        {
            List<Ogrenci> ogrenciler = _context.Ogrenciler.ToList(); 

            return View(ogrenciler);
        }

        public IActionResult StajPuanla(int id)
        {
            Ogrenci puanla = new Ogrenci();
            puanla = _context.Ogrenciler.Where(x => x.OgrenciId == id).FirstOrDefault();

            return View(puanla);
        }

        [HttpPost]
        public JsonResult Puanla(int id, string n1, string n2, string n3, string n4, string n5)
        {
            string sonuc = "0";

            Ogrenci puan_ver = new Ogrenci();


            if (id != 0 && n1 != null && n2 != null && n3 != null && n4 != null && n5 != null )
            {
                puan_ver = (from p in _context.Ogrenciler
                            where p.OgrenciId == id
                            select p).FirstOrDefault();

                if (puan_ver != null)
                {
                    puan_ver.Devam = n1;
                    puan_ver.CalismaVeGayret = n2;
                    puan_ver.IsiVaktindeTamYapma = n3;
                    puan_ver.TavirHareketGenel = n4;
                    puan_ver.TavirHareketIsAkradas = n5;

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

    }
}
