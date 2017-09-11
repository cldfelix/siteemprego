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
    [Route("api/Vagas")]
    public class VagasController : Controller
    {
        private readonly DataContext _context;

        public VagasController(DataContext context)
        {
            _context = context;
        }

        // GET: api/Vagas
        [HttpGet]
        public IEnumerable<Vaga> GetVagas()
        {
            return _context.Vagas;
        }

        // GET: api/Vagas/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetVaga([FromRoute] long id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var vaga = await _context.Vagas
            .Include(m=> m.Candidaturas)
            .Include(m=> m.Usuario)
            .SingleOrDefaultAsync(m => m.IdVaga == id);

            if (vaga == null)
            {
                return NotFound();
            }
            vaga.Usuario.Vagas =  null;
            vaga.Usuario.Candidaturas =  null;
            vaga.Usuario.Password = null;

            return Ok(vaga);
        }

        // PUT: api/Vagas/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutVaga([FromRoute] long id, [FromBody] Vaga vaga)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != vaga.IdVaga)
            {
                return BadRequest();
            }

            _context.Entry(vaga).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!VagaExists(id))
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

        // POST: api/Vagas
        [HttpPost]
        public async Task<IActionResult> PostVaga([FromBody] Vaga vaga)
        {
            Console.WriteLine(vaga);

            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            _context.Vagas.Add(vaga);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetVaga", new { id = vaga.IdVaga }, vaga);
        }

        // DELETE: api/Vagas/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteVaga([FromRoute] long id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var vaga = await _context.Vagas.SingleOrDefaultAsync(m => m.IdVaga == id);
            if (vaga == null)
            {
                return NotFound();
            }

            _context.Vagas.Remove(vaga);
            await _context.SaveChangesAsync();

            return Ok(vaga);
        }

        private bool VagaExists(long id)
        {
            return _context.Vagas.Any(e => e.IdVaga == id);
        }
    }
}