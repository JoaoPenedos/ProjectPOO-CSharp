using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectPOO.Models
{
    public class Pessoa
    {
        public Pessoa(string email, string nome, int numeroTelemovel)
        {
            this.Email = email;
            this.Nome = nome;
            this.NumeroTelemovel = numeroTelemovel;
        }

        public string Email { get; set; }

        public string Nome { get; set; }

        public int NumeroTelemovel { get; set; }
    }
}
