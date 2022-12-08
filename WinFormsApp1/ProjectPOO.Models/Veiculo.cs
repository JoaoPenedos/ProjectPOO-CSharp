using ProjectPOO.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectPOO.Models
{
    public abstract class Veiculo
    {
        public Veiculo(string modelo, double custoMinuto, double custoReserva, EstadoVeiculo estadoVeiculo, int kilometros = 0)
        {
            this.Modelo = modelo;
            this.CustoMinuto = custoMinuto;
            this.CustoReserva = custoReserva;
            this.EstadoVeiculo = estadoVeiculo;
            this.Kilometros = kilometros;
        }

        public Veiculo(string modelo, double custoMinuto, double custoReserva, int kilometros = 0)
        {
            this.Modelo = modelo;
            this.CustoMinuto = custoMinuto;
            this.CustoReserva = custoReserva;
            this.EstadoVeiculo = EstadoVeiculo.Ativo;
            this.Kilometros = kilometros;
        }


        public int Kilometros { get; protected set; }

        public string Modelo { get; set; }

        public double CustoMinuto { get; set; }

        public double CustoReserva { get; set; }

        public EstadoVeiculo EstadoVeiculo { get; protected set; }


        public abstract void UpdateKilometros(int newKilometrosTraveled);

        public abstract void UpdateEstadoVeiculo(EstadoVeiculo estadoVeiculo);
    }
}
