using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AkademisyenlerServiceMVC.Models
{
    public class Akademisyen
    {
        public int AkademisyenId { get; set; }
        public string Adi { get; set; }
        public string Soyadi { get; set; }
        public string Email { get; set; }
        public string Sifre { get; set; }
        public string Token { get; set; }
        public string Unvan { get; set; }
    }
}
