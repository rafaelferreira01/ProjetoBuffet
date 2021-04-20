using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Threading.Tasks;
using ProjetoBuffet.Models.Buffet.Cliente;
using Microsoft.AspNetCore.Mvc;
using ProjetoBuffet.Models.Acesso;
using ProjetoBuffet.RequestModels;
using ProjetoBuffet.ViewModels.Acesso;


namespace ProjetoBuffet.Controllers
{
    public class AcessoController : Controller
    {
        private readonly AcessoService _acessoService;
        
        public AcessoController(AcessoService acessoService)
        {
            _acessoService = acessoService;
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
        
        [HttpGet]
        public IActionResult CriarConta()//visualizacao
        {
            var viewmodel = new CadastrarViewModel();

            viewmodel.Mensagem = (string) TempData["msg-cadastro"];
            
            return View(viewmodel);
        }
        
        [HttpPost]
        /*public RedirectResult CriarConta(AcessoCadastrarRequestModels request)//processamento*/
        public async Task<RedirectToActionResult> CriarConta(AcessoCadastrarRequestModels request)//processamento
        {
            /*var redirectUrl = "/Acesso/CriarConta";*/

            var email = request.Email;
            var senha = request.Email;

            if (email == null)
            {
                TempData["msg-cadastro"] = "Por favor informe o e-mail";
                /*return Redirect(redirectUrl);*/
                return RedirectToAction("CriarConta");
            }

            try
            {
                await _acessoService.RegistraUsuario(email, senha);
                TempData["msg-cadastro"] = "Cadastro realizado com sucesso.";
                return RedirectToAction("Login");
                /*return Redirect("/Acesso/Login");*/
            }
            catch (Exception exception)
            {
                TempData["msg-cadastro"] = exception.Message;
                return RedirectToAction("CriarConta");
            }
            
            /*return Redirect(redirectUrl);*/
            
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