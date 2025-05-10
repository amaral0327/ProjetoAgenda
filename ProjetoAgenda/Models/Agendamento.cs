using System;

namespace ProjetoAgenda.Models
{
    public class Agendamento
    {
        public int Id { get; set; }
        public DateTime DataHora { get; set; }

         //Relações
        public int ClienteId { get; set; }
        public Cliente Cliente { get; set; }

        public int BardeiroId { get; set; }
        public Barbeiro Barbeiro { get; set; }
         
    }
}
