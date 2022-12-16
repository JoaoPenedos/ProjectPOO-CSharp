using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectPOO.Models
{
    public class Funcionario : Pessoa, IPessoa
    {
        public Funcionario(string email, string nome, string password, int numeroTelemovel, DateTime dataEntrada)
             : base(email, nome, password, numeroTelemovel)
        {
            this.DataEntrada = dataEntrada;
        }

        public uint Id { get; set; }

        public DateTime DataEntrada { get; set; }
    }
}
