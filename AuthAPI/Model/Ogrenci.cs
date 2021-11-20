using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AuthAPI.Model
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
    }
}
