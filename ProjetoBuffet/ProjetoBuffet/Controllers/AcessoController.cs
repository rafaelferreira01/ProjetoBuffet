using System;
using System.Collections.Generic;
using System.Diagnostics;
using ProjetoBuffet.Models.Buffet.Cliente;
using Microsoft.AspNetCore.Mvc;


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

            /*var clientes = _clienteService.ObterClientes();

            foreach (var cliente in clientes)
            {
                Console.WriteLine("----");
                Console.WriteLine(cliente.Id);
                Console.Write(" :: " + cliente.Nome);
                Console.Write(" :: " + cliente.Email);
            }*/
            
            return View();
        }
        
        public IActionResult RecuperarConta()
        {
            return View();
        }
        
        public IActionResult CriarConta()
        {
            return View();
        }
        
        public IActionResult PoliticaDePrivacidade()
        {
            return View();
        }
        
        
        /*
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel {RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier});
        }
        */
        
    }
}