using System;
using System.Collections.Generic;

namespace ProjetoBuffet.Models.Buffet.Cliente
{
    public class ClienteService
    {
        
        
        public List<ClienteEntity> ObterClientes()
        {
            var listaDeClientes = new List<ClienteEntity>();
            
            listaDeClientes.Add(new ClienteEntity
            {
                Id = 1,
                Nome = "Leonardo",
                DataDeNascimento = new DateTime(1977, 09, 25)
            });
            
            
            listaDeClientes.Add(new ClienteEntity
            {
                Id = 2,
                Nome = "Rafael",
                DataDeNascimento = new DateTime(1989, 06, 01)
            });

            return listaDeClientes;

        }
    }
}