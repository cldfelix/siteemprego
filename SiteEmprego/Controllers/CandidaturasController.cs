using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SiteEmprego.Models;

namespace SiteEmprego.Controllers
{
    [Produces("application/json")]
    [Route("api/Candidaturas")]
    public class CandidaturasController : Controller
    {
        private readonly DataContext _context;

        public CandidaturasController(DataContext context)
        {
            _context = context;
        }

        // GET: api/Candidaturas
        [HttpGet]
        public IEnumerable<Candidatura> GetCandidaturas()
        {
            return _context.Candidaturas;
        }

        // GET: api/Candidaturas/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetCandidatura([FromRoute] long id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var candidatura = await _context.Candidaturas.SingleOrDefaultAsync(m => m.Idcandidatura == id);

            if (candidatura == null)
            {
                return NotFound();
            }

            return Ok(candidatura);
        }

        // PUT: api/Candidaturas/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutCandidatura([FromRoute] long id, [FromBody] Candidatura candidatura)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != candidatura.Idcandidatura)
            {
                return BadRequest();
            }

            _context.Entry(candidatura).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!CandidaturaExists(id))
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

        // POST: api/Candidaturas
        [HttpPost]
        public async Task<IActionResult> PostCandidatura([FromBody] Candidatura candidatura)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            _context.Candidaturas.Add(candidatura);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetCandidatura", new { id = candidatura.Idcandidatura }, candidatura);
        }

        // DELETE: api/Candidaturas/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteCandidatura([FromRoute] long id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var candidatura = await _context.Candidaturas.SingleOrDefaultAsync(m => m.Idcandidatura == id);
            if (candidatura == null)
            {
                return NotFound();
            }

            _context.Candidaturas.Remove(candidatura);
            await _context.SaveChangesAsync();

            return Ok(candidatura);
        }

        private bool CandidaturaExists(long id)
        {
            return _context.Candidaturas.Any(e => e.Idcandidatura == id);
        }
    }
}