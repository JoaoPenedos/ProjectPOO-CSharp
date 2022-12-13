using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectPOO.Models
{
    public class Utilizador : Pessoa
    {
        public Utilizador(string email, string nome, string password, int numeroTelemovel, DateTime dataNascimento, string Morada)
            : base(email, nome, password, numeroTelemovel)
        {
            this.DataNascimento = dataNascimento;
            this.Morada = Morada;
        }

        public uint Id { get; set; }

        public DateTime DataNascimento { get; set; }

        public string Morada { get; set;}


        public int Age() => DateTime.Now.Year - this.DataNascimento.Year;
    }
}
