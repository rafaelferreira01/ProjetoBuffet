using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace ProjetoBuffet.Models.Acesso
{
    public class AcessoService
    {
        private readonly UserManager<Usuario> _userManager;
        private readonly SignInManager<Usuario> _signInManager;

        public AcessoService(
            UserManager<Usuario> userManager,
            SignInManager<Usuario> signInManager
        ){
            _userManager = userManager;
            _signInManager = signInManager;
        }

        public async Task RegistraUsuario(string email, string senha)
        {
            var novoUsuario = new Usuario()
            {
                UserName = email,
                Email = email
            };

            var resultado = await _userManager.CreateAsync(novoUsuario, senha);

            if (!resultado.Succeeded)
            {
                var listaErros = "";
                foreach (var identityError in resultado.Errors)
                {
                    listaErros += identityError.Description + " - ";
                }

                throw new Exception(listaErros);
            }
            
        }   
        
    }
}