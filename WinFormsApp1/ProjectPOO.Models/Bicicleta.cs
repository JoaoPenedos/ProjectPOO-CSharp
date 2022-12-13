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
        public Bicicleta(string modelo, double custoMinuto, double custoReserva, EstadoVeiculo estadoVeiculo, int kilometros = 0)
        {
            this.Modelo = modelo;
            this.CustoMinuto = custoMinuto;
            this.CustoReserva = custoReserva;
            this.EstadoVeiculo = estadoVeiculo;
            this.Kilometros = kilometros;
            this.TipoVeiculo = TipoVeiculo.Bicicleta;
        }

        public Bicicleta(string modelo, double custoMinuto, double custoReserva, int kilometros = 0)
        {
            this.Modelo = modelo;
            this.CustoMinuto = custoMinuto;
            this.CustoReserva = custoReserva;
            this.Kilometros = kilometros;
            this.EstadoVeiculo = EstadoVeiculo.Ativo;
            this.TipoVeiculo = TipoVeiculo.Bicicleta;
        }

        [Browsable(false)]
        public uint Id { get; set; }

        public string Designacao { get; set; }

        public string Modelo { get; set; }

        public double CustoMinuto { get; set; }

        public double CustoReserva { get; set; }

        public EstadoVeiculo EstadoVeiculo { get; set; }

        public int Kilometros { get; set; }

        public TipoVeiculo TipoVeiculo { get; set; }



        public void UpdateKilometros(int newKilometrosTraveled) => this.Kilometros += newKilometrosTraveled;

        public void UpdateEstadoVeiculo(EstadoVeiculo estadoVeiculo) => this.EstadoVeiculo = estadoVeiculo;

        public void SetDesignacao(uint lastBicicletaID) => this.Designacao = "Bicicleta_N" + lastBicicletaID.ToString("00");
    }
}
