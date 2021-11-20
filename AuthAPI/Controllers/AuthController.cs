using AuthAPI.Database;
using AuthAPI.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AuthAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private readonly DatabaseContext _context;
        IConfiguration _configuration;
        public AuthController(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        
        public IActionResult Login(string email, string sifre)
        {
            TokenHandler._configuration = _configuration;
            return Ok(email == "f171213049@ktun.edu.tr" && sifre == "12345" ?TokenHandler.CreateAccessToken() : new UnauthorizedResult());

        }
    }
}
/* AuthController oluşturuldu
 * Token üretimi için TokenHandler sınıfı oluşturuldu
 * launchsettings.json dosyası içerisinde api/controller path leri düzeltildi.
 * TokenHandler sınıfı burada kullanıldı.
 * 
 *             var kullanici = _context.Ogrenciler.Where(s => s.Email == Email && s.Sifre == Sifre).FirstOrDefault();
            if (kullanici == null)
                return null;
            else
            {
                TokenHandler.CreateAccessToken(); 
                return  new UnauthorizedResult();
                
            }
 * 
 *             var kullanici_kontrol = _context.Ogrenciler.Where(x => x.Email == ogrenci.Email && x.Sifre == ogrenci.Sifre).FirstOrDefault();
            TokenHandler._configuration = _configuration;     
            return Ok(kullanici_kontrol.Email == kullanici_kontrol.Email && kullanici_kontrol.Sifre == kullanici_kontrol.Sifre ? TokenHandler.CreateAccessToken() : new UnauthorizedResult());
 * 
 * 
 * 
 */