using ProjectPOO.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectPOO.Models
{
    public interface IVeiculo
    {
        #region Propriedades

        /// <summary>
        /// Id de Veiculo
        /// </summary>
        //[Browsable(false)]
        uint Id { get; set; }

        /// <summary>
        /// Designacao de Veiculo
        /// </summary>
        string Designacao { get; set; }

        /// <summary>
        /// Modelo de Veiculo
        /// </summary>
        string Modelo { get; set; }

        /// <summary>
        /// Custo Minuto de Veiculo
        /// </summary>
        double CustoMinuto { get; set; }

        /// <summary>
        /// Custo Reserva de Veiculo
        /// </summary>
        double CustoReserva { get; set; }

        /// <summary>
        /// Estado atual de Veiculo
        /// </summary>
        EstadoVeiculo EstadoVeiculo { get; set; }

        /// <summary>
        /// Kilometros de Veiculo
        /// </summary>
        int Kilometros { get; protected set; }

        /// <summary>
        /// Tipo de Veiculo
        /// </summary>
        TipoVeiculo TipoVeiculo { get; set; }

        #endregion


        #region Metodos

        /// <summary>
        /// Metodo que atualiza os kilometros do veiculo
        /// </summary>
        /// <param name="newKilometrosTraveled">kilometros viagados</param>
        void UpdateKilometros(int newKilometrosTraveled);

        /// <summary>
        /// Metodo que insere o valor certo nos Ids de Veiculo
        /// </summary>
        /// <param name="lastVeciculoTypeID">Id do ultimo veiculo na lista</param>
        void SetDesignacao(uint lastVeciculoTypeID);

        #endregion
    }
}
