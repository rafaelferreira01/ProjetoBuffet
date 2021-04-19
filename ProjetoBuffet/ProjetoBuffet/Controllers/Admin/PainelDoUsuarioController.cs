using System;
using System.Collections.Generic;
using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
// using Buffet.Models;
// using Buffet.ViewModels.Home;

namespace ProjetoBuffet.Controllers.Admin
{
    public class PainelDoUsuarioController : Controller
    {
        public PainelDoUsuarioController()
        {
        }

        public IActionResult Index()
        {
            return View();
        }
    }
}