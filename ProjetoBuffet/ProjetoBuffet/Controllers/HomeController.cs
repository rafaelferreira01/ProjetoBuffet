using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
// using ASP;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ProjetoBuffet.Data;
using ProjetoBuffet.Models;
using ProjetoBuffet.Models.Buffet.Cliente;
// using ProjetoBuffet.ViewModels.Home;
using ProjetoBuffet.Views.Home;

namespace ProjetoBuffet.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly ClienteService _clienteService;

        public HomeController(
            ILogger<HomeController> logger,
            ClienteService clienteService
            ){
            _logger = logger;
            _clienteService = clienteService;
        }

        public IActionResult Index()
        {
            // 1ª forma de eviar dados para a view
            ViewBag.informacaoQualquer = "Imformação Qualquer";

            // 2ª forma de eviar dados para a view
            ViewData["Informacao"] = "Outra Informação";

            // 3ª forma de eviar dados para a view
            var viewmodel = new IndexViewModel();
            viewmodel.InformacaoQualquer = "Informação pela View Model";
            viewmodel.Titulo = "Titulo Qualquer";
            viewmodel.UsuarioLogado = new Usuario()
            {
                Nome = "Rafael",
                Idade = 32
            };
            
            //trazer lista de clientes do banco de dados
            var clientesDoBanco = _clienteService.ObterClientes();
            foreach (var clienteEntity in clientesDoBanco)
            {
                viewmodel.Clientes.Add(new Cliente()
                {
                    Id = clienteEntity.Id.ToString(),
                    Nome = clienteEntity.Nome
                });
            }
            
            
            
            return View();
        }

        //TESTE
        // private readonly ILogger<HomeController> _logger;
        // private readonly DatabaseContext _databaseContext;
        // public HomeController(
        //     ILogger<HomeController> logger,
        //     DatabaseContext databaseContext
        //     )
        // {
        //     _logger = logger;
        //     _databaseContext = databaseContext;
        // }
        //
        // public IActionResult Index()
        // {
        //     var todosClientes:List<ClienteEntity> = _databaseContext.Clientes.ToList();
        //     return View();
        // }
        //
        //
        //FIM TESTE

        

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
        
        
        
        // public IActionResult Clientes()
        // {
        //     
        //     //trazer lista de entidade clientes do serviço de clientes (model)
        //     //tirar isso depois
        //     var clienteService = new ClienteService();
        //     var listaDeClientes = clienteService.ObterClientes();
        //
        //     //criar e popular viewmodel
        //     var viewModel = new ClientesViewModel();
        //     foreach (ClienteEntity clienteEntity in listaDeClientes)
        //     {
        //         viewModel.Clientes.Add(new Cliente
        //         {
        //             Nome = clienteEntity.Nome,
        //             DataDeNascimento = clienteEntity.DataDeNascimento.ToShortDateString()
        //         });
        //     }
        //     
        //     
        //     
        //     return View(viewModel);
        // }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel {RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier});
        }
    }
}