using ProjectPOO.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectPOO.Models
{
    public class Bicicleta : Veiculo
    {
        private readonly int lastBicicletaID = -1;

        public Bicicleta(string modelo, double custoMinuto, double custoReserva, EstadoVeiculo estadoVeiculo, int kilometros = 0)
            : base(modelo, custoMinuto, custoReserva, estadoVeiculo, kilometros)
        {
            this.BicicletaID = lastBicicletaID + 1;
        }

        public Bicicleta(string modelo, double custoMinuto, double custoReserva, int kilometros = 0) 
            : base(modelo, custoMinuto, custoReserva, kilometros)
        {
            this.BicicletaID = lastBicicletaID + 1;
        }

        public int BicicletaID { get; set; }

        public override void UpdateKilometros(int newKilometrosTraveled) => this.Kilometros += newKilometrosTraveled;

        public override void UpdateEstadoVeiculo(EstadoVeiculo estadoVeiculo) => this.EstadoVeiculo = estadoVeiculo;
    }
}
