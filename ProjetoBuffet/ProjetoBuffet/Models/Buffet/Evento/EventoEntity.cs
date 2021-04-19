using System;
using ProjetoBuffet.Models.Buffet.Cliente;

namespace ProjetoBuffet.Models.Buffet.Evento
{
    public class EventoEntity
    {
        public Guid Id { get; set; }
        public string Nome { get; set; }
        public ClienteEntity Cliente { get; set; }

        public EventoEntity(Guid id)
        {
            Id = new Guid();
        }
    }
}