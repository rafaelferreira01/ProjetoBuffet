using System;
using System.Collections;
using System.Collections.Generic;
using ProjetoBuffet.Models.Buffet.Evento;

namespace ProjetoBuffet.Models.Buffet.Cliente
{
    public class ClienteEntity
    {
        public Guid Id { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }

        public ICollection<EventoEntity> Eventos { get; set; }
        public ClienteEntity(Guid id)
        {
            Id = new Guid();
            Eventos = new List<EventoEntity>();
        }
    }
}