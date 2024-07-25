 using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using AssabileApi.Models;

namespace AssabileApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ReadingordersController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public ReadingordersController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: api/Readingorders
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Readingorder>>> GetReadingorders()
        {
            return await _context.Readingorders.Take(15).ToListAsync();
        }

        // GET: api/Readingorders/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Readingorder>> GetReadingorder(string id)
        {
            var readingorder = await _context.Readingorders.FindAsync(id);

            if (readingorder == null)
            {
                return NotFound();
            }

            return readingorder;
        }

        // PUT: api/Readingorders/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutReadingorder(string id, Readingorder readingorder)
        {
            if (id != readingorder.ReadingorderCode)
            {
                return BadRequest();
            }

            _context.Entry(readingorder).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ReadingorderExists(id))
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

        // POST: api/Readingorders
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Readingorder>> PostReadingorder(Readingorder readingorder)
        {
            _context.Readingorders.Add(readingorder);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (ReadingorderExists(readingorder.ReadingorderCode))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetReadingorder", new { id = readingorder.ReadingorderCode }, readingorder);
        }

        // DELETE: api/Readingorders/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteReadingorder(string id)
        {
            var readingorder = await _context.Readingorders.FindAsync(id);
            if (readingorder == null)
            {
                return NotFound();
            }

            _context.Readingorders.Remove(readingorder);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool ReadingorderExists(string id)
        {
            return _context.Readingorders.Any(e => e.ReadingorderCode == id);
        }
    }
}
