using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SiteEmprego.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace SiteEmprego.Controllers
{
    [Route("api/[controller]")]
    public class UsuarioController : Controller
    {
        private readonly DataContext _context;
        public UsuarioController(DataContext ctx)
        {
            _context = ctx;
        }

        // GET: api/usuarios
        [HttpGet]
        public IEnumerable<Usuario> Get()
        {
            var ret = _context.Usuarios;
            foreach (var usuario in ret)
            {
                usuario.Password = null;
            }
            return ret;
        }

        // GET api/usuarios/5
        [HttpGet("{id}")]
        public Usuario Get(long id)
        {
            var ret = _context.Usuarios.Include(u => u.Vagas).Include(u => u.Candidaturas).First(u=>u.IdUsuario == id);
            foreach (var vaga in ret.Vagas)
            {
                vaga.Usuario = null;
            }

            foreach (var cand in ret.Candidaturas)
            {
                cand.Usuario = null;
                cand.Vaga = null;
            }

            return ret;

        }

        // POST api/usuarios
        [HttpPost]
        public IActionResult PostUsuario([FromBody] Usuario usuario)
        {
            if (!ModelState.IsValid) return BadRequest(ModelState);
            usuario.CriadoEm = DateTime.Now;
            _context.Usuarios.Add(usuario);
            _context.SaveChanges();

            return Ok();
        }

   

        // PUT api/usuarios/5   
        [HttpPut]
        public IActionResult ReplaceProduct([FromBody] Usuario usuario)
        {
            if (!ModelState.IsValid) return BadRequest(ModelState);

            _context.Update(usuario);
            _context.SaveChanges();

            return Ok();
        }



        // DELETE api/usuarios/5
        [HttpDelete("{id}")]
        public IActionResult DeleteUsuario(long id)
        {
            var usuario = _context.Usuarios.FindAsync(id);

            if (usuario.Result == null) return BadRequest("Usuario não existe!");

            usuario.Result.UsuarioAtivo = false;
            _context.SaveChanges();
            return Ok();
            //_context.Update(usuario);
        }
    }
}
