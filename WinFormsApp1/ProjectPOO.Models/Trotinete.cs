using ProjectPOO.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectPOO.Models
{
    public class Trotinete : Veiculo
    {
        private readonly int lastTrotineteID = -1;

        public Trotinete(string modelo, double custoMinuto, double custoReserva, EstadoVeiculo estadoVeiculo, int kilometros = 0)
            : base(modelo, custoMinuto, custoReserva, estadoVeiculo, kilometros)
        {
            this.TrotineteID = lastTrotineteID + 1;
        }

        public Trotinete(string modelo, double custoMinuto, double custoReserva, int kilometros = 0)
            : base(modelo, custoMinuto, custoReserva, kilometros)
        {
            this.TrotineteID = lastTrotineteID + 1;
        }

        public int TrotineteID { get; set; }

        public override void UpdateKilometros(int newKilometrosTraveled) => this.Kilometros += newKilometrosTraveled;

        public override void UpdateEstadoVeiculo(EstadoVeiculo estadoVeiculo) => this.EstadoVeiculo = estadoVeiculo;
    }
}
