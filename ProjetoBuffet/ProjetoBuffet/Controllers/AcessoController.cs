using System;
using System.Collections.Generic;

using System.Threading.Tasks;

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

        [HttpGet]
        public IActionResult Login()
        {
            var viewmodel = new LoginViewModel();
            
            viewmodel.Mensagem = (string) TempData["msg-login"];
            
            return View(viewmodel);
        }
        
        [HttpPost]
        public async Task<RedirectResult> Login(AcessoLoginRequestModels request)
        {
            /*var redirectUrl = "/Acesso/Login";*/
            var email = request.Email;
            var senha = request.Senha;
            
            if (email == null)
            {
                TempData["msg-login"] = "Por favor informe o e-mail";
                /*return Redirect(redirectUrl);*/
                return Redirect(url:"/Acesso/Login");
            }
            
            try
            {
                await _acessoService.AutenticarUsuario(email, senha);
                /*TempData["msg-login"] = "Login realizado com sucesso!";*/
                return Redirect(url:"/Privado/Index");
                
            }
            catch (Exception exception)
            {
                TempData["msg-login"] = exception.Message;
                return Redirect(url:"/Acesso/Login");
            }
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
            viewmodel.ErrosCadastro = (string[]) TempData["erros-cadastro"];
            
            return View(viewmodel);
        }
        
        [HttpPost]
        /*public RedirectResult CriarConta(AcessoCadastrarRequestModels request)//processamento*/
        public async Task<RedirectToActionResult> CriarConta(AcessoCadastrarRequestModels request)//processamento
        {
            /*var redirectUrl = "/Acesso/CriarConta";*/

            var email = request.Email;
            var senha = request.Senha;

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
            catch (CadastrarUsuarioException exception)
            {
                var listaErros = new List<string>();
                
                foreach (var identityError in exception.Erros)
                {
                    listaErros.Add(identityError.Description);
                }
                
                
                TempData["erros-cadastro"] = listaErros;
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