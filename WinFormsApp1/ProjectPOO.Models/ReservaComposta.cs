using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectPOO.Models
{
    public class ReservaComposta
    {
        /// <summary>
        /// Nome do utilizador que possui a determinada reserva
        /// </summary>
        public string Nome { get; set; }

        /// <summary>
        /// Data da determinada reserva
        /// </summary>
        public DateTime DataReserva { get; set; }

        /// <summary>
        /// Designacao do posto escolhido para reserva
        /// </summary>
        //public string PostoDesignacao { get; set; }

        /// <summary>
        /// Designacao do veiculo escolhido para reserva
        /// </summary>
        public string VeiculoDesignacao { get; set; }
    }
}
