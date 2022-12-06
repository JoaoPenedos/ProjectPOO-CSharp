using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectPOO.Models
{
    public class Funcionario : Pessoa
    {
        public Funcionario(string email, string nome, int numeroTelemovel)
             : base(email, nome, numeroTelemovel)
        {

        }
    }
}
