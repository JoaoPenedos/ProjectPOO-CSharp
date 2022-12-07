using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectPOO.Models
{
    public class Funcionario : Pessoa
    {
        public Funcionario(string email, string nome, int numeroTelemovel, int funcionarioID)
             : base(email, nome, numeroTelemovel)
        {
            this.FuncionarioID = funcionarioID;
        }

        public int FuncionarioID { get; set; }
    }
}
