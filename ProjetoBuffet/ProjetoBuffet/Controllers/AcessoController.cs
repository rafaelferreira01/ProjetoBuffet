using System;
using System.Collections.Generic;
using System.Diagnostics;
using Buffet.Models.Buffet.Cliente;
using Microsoft.AspNetCore.Mvc;
using ProjetoBuffet.Models.Buffet.Cliente;

namespace ProjetoBuffet.Controllers
{
    public class AcessoController : Controller
    {
        private readonly ClienteService _clienteService;
        
        public AcessoController(ClienteService clienteService)
        {
            _clienteService = clienteService;
        }

        public IActionResult Login()
        {

            var clientes = _clienteService.ObterClientes();

            foreach (var cliente in clientes)
            {
                Console.WriteLine("----");
                Console.WriteLine(cliente.Id);
                Console.Write(" :: " + cliente.Nome);
                Console.Write(" :: " + cliente.Email);
            }
            
            return View();
        }
        
        public IActionResult RecuperarConta()
        {
            return View();
        }
        
        public IActionResult Cadastrar()
        {
            return View();
        }
    }
}