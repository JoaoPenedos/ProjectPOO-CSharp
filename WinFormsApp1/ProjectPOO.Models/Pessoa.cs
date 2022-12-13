using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectPOO.Models
{
    public abstract class Pessoa
    {
        public Pessoa(string email, string nome, string password, int numeroTelemovel)
        {
            this.Email = email;
            this.Nome = nome;
            this.Password = password;
            this.NumeroTelemovel = numeroTelemovel;
        }

        public string Email { get; set; }

        public string Nome { get; set; }

        public string Password { get; set; }

        public int NumeroTelemovel { get; set; }
    }
}
