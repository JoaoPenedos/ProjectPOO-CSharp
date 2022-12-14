using ProjectPOO.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectPOO.Models
{
    public class Reserva
    {
        public Reserva(DateTime dataReserva, uint utilizadorId,/* uint postoId, */uint veiculoId) 
        {
            this.DataReserva = dataReserva;
            this.UtilizadorId = utilizadorId;
            //this.PostoId = postoId;
            this.VeiculoId = veiculoId;
            this.EstadoReserva = EstadoReserva.EmEspera;
        }

        public uint Id { get; set; }

        public DateTime DataReserva { get; set; }

        public DateTime DataCancelamento { get; set; }

        public uint UtilizadorId { get; set; }

        //public uint PostoId { get; set; }

        public uint VeiculoId { get; set; }

        public EstadoReserva EstadoReserva { get; set; }
    }
}
