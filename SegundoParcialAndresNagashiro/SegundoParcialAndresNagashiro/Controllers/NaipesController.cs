using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SegundoParcialAndresNagashiro.Data;
using SegundoParcialAndresNagashiro.Models;

namespace SegundoParcialAndresNagashiro.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class NaipesController : ControllerBase
    {
        private readonly AppDbContext _context;

        public NaipesController(AppDbContext context)
        {
            _context = context;
        }

        // GET: api/Naipes
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Naipe>>> GetNaipes()
        {
            return await _context.Naipes.ToListAsync();
        }

        // GET: api/Naipes/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Naipe>> GetNaipe(string id)
        {
            var naipe = await _context.Naipes.FindAsync(id);

            if (naipe == null)
            {
                return NotFound();
            }

            return naipe;
        }

        // PUT: api/Naipes/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutNaipe(string id, Naipe naipe)
        {
            if (id != naipe.naipe)
            {
                return BadRequest();
            }

            _context.Entry(naipe).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!NaipeExists(id))
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

        // POST: api/Naipes
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Naipe>> PostNaipe(Naipe naipe)
        {
            _context.Naipes.Add(naipe);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (NaipeExists(naipe.naipe))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetNaipe", new { id = naipe.naipe }, naipe);
        }

        // DELETE: api/Naipes/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteNaipe(string id)
        {
            var naipe = await _context.Naipes.FindAsync(id);
            if (naipe == null)
            {
                return NotFound();
            }

            _context.Naipes.Remove(naipe);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool NaipeExists(string id)
        {
            return _context.Naipes.Any(e => e.naipe == id);
        }
    }
}
