using ProjectPOO.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectPOO.Models
{
    public class Bicicleta : IVeiculo
    {
        #region Construtor

        /// <summary>
        /// Construtor para a bicicleta
        /// </summary>
        /// <param name="modelo">modelo da bicicleta</param>
        /// <param name="custoMinuto">custo por minuto da bicicleta</param>
        /// <param name="custoReserva">custo da reserva da bicicleta</param>
        /// <param name="estadoVeiculo">estado da bicicleta</param>
        /// <param name="kilometros">kilometros da bicicleta</param>
        public Bicicleta(string modelo, double custoMinuto, double custoReserva, EstadoVeiculo estadoVeiculo, int kilometros = 0)
        {
            this.Modelo = modelo;
            this.CustoMinuto = custoMinuto;
            this.CustoReserva = custoReserva;
            this.EstadoVeiculo = estadoVeiculo;
            this.Kilometros = kilometros;
            this.TipoVeiculo = TipoVeiculo.Bicicleta;
        }

        /// <summary>
        /// Construtor para a bicicleta
        /// </summary>
        /// <param name="modelo">modelo da bicicleta</param>
        /// <param name="custoMinuto">custo por minuto da bicicleta</param>
        /// <param name="custoReserva">custo da reserva da bicicleta</param>
        /// <param name="kilometros">kilometros da bicicleta</param>
        public Bicicleta(string modelo, double custoMinuto, double custoReserva, int kilometros = 0)
        {
            this.Modelo = modelo;
            this.CustoMinuto = custoMinuto;
            this.CustoReserva = custoReserva;
            this.Kilometros = kilometros;
            this.EstadoVeiculo = EstadoVeiculo.Ativo;
            this.TipoVeiculo = TipoVeiculo.Bicicleta;
        }

        #endregion


        #region Propriedades

        /// <summary>
        /// Id de Bicicleta
        /// </summary>
        //[Browsable(false)]
        public uint Id { get; set; }

        /// <summary>
        /// Designacao de Bicicleta
        /// </summary>
        public string Designacao { get; set; }

        /// <summary>
        /// Modelo de Bicicleta
        /// </summary>
        public string Modelo { get; set; }

        /// <summary>
        /// Custo Minuto de Bicicleta
        /// </summary>
        public double CustoMinuto { get; set; }

        /// <summary>
        /// Custo Reserva de Bicicleta
        /// </summary>
        public double CustoReserva { get; set; }

        /// <summary>
        /// Estado atual de Bicicleta
        /// </summary>
        public EstadoVeiculo EstadoVeiculo { get; set; }

        /// <summary>
        /// Kilometros de Bicicleta
        /// </summary>
        public int Kilometros { get; set; }

        /// <summary>
        /// Tipo de Bicicleta
        /// </summary>
        public TipoVeiculo TipoVeiculo { get; set; }

        #endregion


        #region Metodos

        /// <summary>
        /// Metodo que atualiza os kilometros da Bicicleta
        /// </summary>
        /// <param name="newKilometrosTraveled">kilometros viagados</param>
        public void UpdateKilometros(int newKilometrosTraveled) => this.Kilometros += newKilometrosTraveled;

        /// <summary>
        /// Metodo que insere o valor certo nos Ids da Bicicleta
        /// </summary>
        /// <param name="lastVeciculoTypeID">Id da ultima Bicicleta na lista</param>
        public void SetDesignacao(uint lastBicicletaID) => this.Designacao = "Bicicleta_N" + lastBicicletaID.ToString("000");

        #endregion
    }
}
