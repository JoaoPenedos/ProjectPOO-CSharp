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
        //[Browsable(false)]
        public uint Id { get; set; }

        public string Designacao { get; set; }

        public string Modelo { get; set; }

        public double CustoMinuto { get; set; }

        public double CustoReserva { get; set; }

        public EstadoVeiculo EstadoVeiculo { get; set; }

        public int Kilometros { get; protected set; }

        public TipoVeiculo TipoVeiculo { get; set; }



        public void UpdateKilometros(int newKilometrosTraveled);

        public void SetDesignacao(uint lastVeciculoTypeID);
    }
}
