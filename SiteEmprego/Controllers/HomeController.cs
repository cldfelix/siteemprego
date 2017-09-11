using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SiteEmprego.Models;

namespace SiteEmprego.Controllers
{
    public class HomeController : Controller
    {
        private DataContext context;
        public HomeController(DataContext ctx)
        {
            context = ctx;
        } 
        public IActionResult Index()
        {
            return View(context.Usuarios); //.Include(u => u.Vagas).FirstOrDefaultAsync(u => u.IdUsuario == 2));
            //return View();
        }

     

        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
