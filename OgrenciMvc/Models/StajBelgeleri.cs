using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OgrenciMvc.Models
{
    public class StajBelgeleri
    {
        public int StajBelgeleriId { get; set; }
        public int OgrenciNumara { get; set; }
        public string DosyaAdi { get; set; }
        public string DosyaTuru { get; set; }
        public string DosyaIcerigi { get; set; }
    }
}
