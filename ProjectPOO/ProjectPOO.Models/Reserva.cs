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
        #region Construtor

        /// <summary>
        /// Construtor para as reservas 
        /// </summary>
        /// <param name="dataReserva">Data da reserva</param>
        /// <param name="utilizadorId">Id do utilizador que realizou a reserva</param>
        /// <param name="veiculoId">Id do veiculo escolhido para a reserva</param>
        public Reserva(DateTime dataReserva, uint utilizadorId/*, uint postoId*/, uint veiculoId) 
        {
            this.DataReserva = dataReserva;
            this.UtilizadorId = utilizadorId;
            //this.PostoId = postoId;
            this.VeiculoId = veiculoId;
            this.EstadoReserva = EstadoReserva.EmEspera;
        }

        #endregion


        #region Propriedades

        /// <summary>
        /// Id da reserva
        /// </summary>
        public uint Id { get; set; }

        /// <summary>
        /// Data da reserva
        /// </summary>
        public DateTime DataReserva { get; set; }

        /// <summary>
        /// Data do cancelamento da reserva
        /// </summary>
        public DateTime DataCancelamento { get; set; }

        /// <summary>
        /// Id do utilizador 
        /// </summary>
        public uint UtilizadorId { get; set; }

        /// <summary>
        /// Id do posto 
        /// </summary>
        //public uint PostoId { get; set; }

        /// <summary>
        /// Id do veiculo
        /// </summary>
        public uint VeiculoId { get; set; }

        /// <summary>
        /// Estado atual da reserva
        /// </summary>
        public EstadoReserva EstadoReserva { get; set; }

        #endregion
    }
}
