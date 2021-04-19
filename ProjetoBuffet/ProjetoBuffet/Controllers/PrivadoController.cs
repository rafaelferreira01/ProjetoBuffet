using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ProjetoBuffet.Models;
using ProjetoBuffet.Models.Buffet.Cliente;
// using ProjetoBuffet.ViewModels.Home;

namespace ProjetoBuffet.Controllers
{
    public class PrivadoController : Controller
    {
        private readonly ILogger<PrivadoController> _logger;
        
        public PrivadoController(ILogger<PrivadoController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }
        
        public IActionResult Ajuda()
        {
            return View();
        }
        
        public IActionResult PainelDoUsuario()
        {
            return View();
        }
        
        public IActionResult Logout()
        {
            return View();
        }
        
        public IActionResult Secao1()
        {
            return View();
        }
        
    }
}