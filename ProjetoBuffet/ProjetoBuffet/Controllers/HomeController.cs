using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ProjetoBuffet.Models;
using ProjetoBuffet.Models.Buffet.Cliente;
using ProjetoBuffet.ViewModels.Home;

namespace ProjetoBuffet.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

       public IActionResult Login()
        {
            return View();
        }
        
        public IActionResult Cadastro()
        {
            return View();
        }
        
        public IActionResult CriarConta()
        {
            return View();
        }
        
        public IActionResult RecuperarConta()
        {
            return View();
        }
        
        public IActionResult PoliticaDePrivacidade()
        {
            return View();
        }
        
        
        
        public IActionResult Clientes()
        {
            
            //trazer lista de entidade clientes do serviço de clientes (model)
            //tirar isso depois
            var clienteService = new ClienteService();
            var listaDeClientes = clienteService.ObterClientes();

            //criar e popular viewmodel
            var viewModel = new ClientesViewModel();
            foreach (ClienteEntity clienteEntity in listaDeClientes)
            {
                viewModel.Clientes.Add(new Cliente
                {
                    Nome = clienteEntity.Nome,
                    DataDeNascimento = clienteEntity.DataDeNascimento.ToShortDateString()
                });
            }
            
            
            
            return View(viewModel);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel {RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier});
        }
    }
}