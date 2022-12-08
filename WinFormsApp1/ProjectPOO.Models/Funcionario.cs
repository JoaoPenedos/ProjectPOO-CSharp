using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectPOO.Models
{
    public class Funcionario : Pessoa
    {
        private readonly int lastFuncionarioID = -1;

        public Funcionario(string email, string nome, int numeroTelemovel)
             : base(email, nome, numeroTelemovel)
        {
            this.FuncionarioID = lastFuncionarioID + 1;
        }

        public int FuncionarioID { get; set; }
    }
}
