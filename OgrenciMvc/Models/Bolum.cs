using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OgrenciMvc.Models
{
    public class Bolum
    {
        public int BolumId { get; set; }
        public int FakulteId { get; set; }
        public string BolumAdi { get; set; }
        public string BolumBaskani { get; set; }
        public string BolumMail { get; set; }
        public string BolumWebSite { get; set; }
        public string Telefon { get; set; }
        public Fakulte Fakulte { get; set; }
    }
}
