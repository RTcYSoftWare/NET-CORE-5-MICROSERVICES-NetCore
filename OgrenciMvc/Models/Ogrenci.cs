using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OgrenciMvc.Models
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
        public string Soru1 { get; set; }
        public string Soru2 { get; set; }
        public string Cevap1 { get; set; }
        public string Cevap2 { get; set; }
        public string ProfilFoto { get; set; }
        public string Devam { get; set; }
        public string CalismaVeGayret { get; set; }
        public string IsiVaktindeTamYapma { get; set; }
        public string TavirHareketGenel { get; set; }
        public string TavirHareketIsAkradas { get; set; }
        public int StajGunu { get; set; }
        public string StajGun1 { get; set; }
        public string StajGun2 { get; set; }
        public string StajGun3 { get; set; }

    }
}
