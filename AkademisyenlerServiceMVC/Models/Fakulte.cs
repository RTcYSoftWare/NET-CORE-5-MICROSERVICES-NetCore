using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AkademisyenlerServiceMVC.Models
{
    public class Fakulte
    {
        public int FakulteId { get; set; }
        public string FakulteAdi { get; set; }
    }
}
