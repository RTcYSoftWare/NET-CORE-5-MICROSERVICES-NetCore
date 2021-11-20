using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using OgrencilerMikroservis.Veritabani;

namespace OgrencilerMikroservis.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize()] // kimlik doğrulama için eklendi
    public class OgrencisController : ControllerBase
    {
        private readonly DatabaseContext _context;

        public OgrencisController(DatabaseContext context)
        {
            _context = context;
        }

        // GET: api/Ogrencis
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Ogrenci>>> GetOgrenciler()
        {
            return await _context.Ogrenciler.ToListAsync();
        }

        // GET: api/Ogrencis/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Ogrenci>> GetOgrenci(int id)
        {
            var ogrenci = await _context.Ogrenciler.FindAsync(id);

            if (ogrenci == null)
            {
                return NotFound();
            }

            return ogrenci;
        }

        // PUT: api/Ogrencis/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutOgrenci(int id, Ogrenci ogrenci)
        {
            if (id != ogrenci.OgrenciId)
            {
                return BadRequest();
            }

            _context.Entry(ogrenci).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!OgrenciExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/Ogrencis
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Ogrenci>> PostOgrenci(Ogrenci ogrenci)
        {
            _context.Ogrenciler.Add(ogrenci);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetOgrenci", new { id = ogrenci.OgrenciId }, ogrenci);
        }

        // DELETE: api/Ogrencis/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteOgrenci(int id)
        {
            var ogrenci = await _context.Ogrenciler.FindAsync(id);
            if (ogrenci == null)
            {
                return NotFound();
            }

            _context.Ogrenciler.Remove(ogrenci);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool OgrenciExists(int id)
        {
            return _context.Ogrenciler.Any(e => e.OgrenciId == id);
        }
    }
}
/*Startup.cs dosyasında kimlik doğrulama için gerekli olan AddAuthentication ve AddJWTBearer servisleri eklendi
 * 
 * 
*/