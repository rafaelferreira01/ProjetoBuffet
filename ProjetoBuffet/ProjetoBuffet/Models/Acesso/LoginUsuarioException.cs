using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Identity;

namespace ProjetoBuffet.Models.Acesso
{
    public class LoginUsuarioException : Exception
    {
        public IEnumerable<IdentityError> Erros { get; set; }

        public LoginUsuarioException(IEnumerable<IdentityError> erros)
        {
            Erros = erros;
        }
    }
}