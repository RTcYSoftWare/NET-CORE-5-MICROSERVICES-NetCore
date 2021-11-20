using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AkademisyenlerServiceMVC.Models
{
    public class Ogrenci
    {
        public int OgrenciId { get; set; }
        public string Adi { get; set; }
        public string SoyAdi { get; set; }
        public string Email { get; set; }
        public string Sifre { get; set; }
        public string Token { get; set; }
        public int BolumId { get; set; }
        public Bolum Bolum { get; set; }
        public StajBelgeleri StajBelgeleri { get; set; }
        public string StajBasvuruFormu { get; set; }
        public string StajSaglikFormu { get; set; }
        public string StajUcertFormu { get; set; }
        public bool StajBasvuruDurumu { get; set; }
    }
}
