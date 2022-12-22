using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectPOO.Models
{
    public class Utilizador : Pessoa, IPessoa
    {
        #region Construtor

        /// <summary>
        /// Construtor para o utilizador
        /// </summary>
        /// <param name="email">email do utilizador</param>
        /// <param name="nome">nome do utilizador</param>
        /// <param name="password">password do utilizador</param>
        /// <param name="numeroTelemovel">numero Telemovel do utilizador</param>
        /// <param name="dataNascimento">data Nascimento do utilizador</param>
        /// <param name="Morada">Morada do utilizador</param>
        /// <param name="saldo">Saldo do utilizador</param>
        public Utilizador(string email, string nome, string password, int numeroTelemovel, DateTime dataNascimento, string Morada, double saldo = 0)
            : base(email, nome, password, numeroTelemovel)
        {
            this.DataNascimento = dataNascimento;
            this.Morada = Morada;
            this.Saldo = saldo;
        }

        #endregion


        #region Propriedades

        /// <summary>
        /// Id do utilizador
        /// </summary>
        public uint Id { get; set; }

        /// <summary>
        /// Data de Nascimento do Utilizador
        /// </summary>
        public DateTime DataNascimento { get; set; }

        /// <summary>
        /// Morada do Utilizador
        /// </summary>
        public string Morada { get; set;}

        /// <summary>
        /// Saldo do Utilizador
        /// </summary>
        public double Saldo { get; set;}

        #endregion


        #region Metodos

        /// <summary>
        /// Metodo que retorna a idade atual do utilizador
        /// </summary>
        /// <returns>Inteiro com a idade do utilizador</returns>
        public int Age() => DateTime.Now.Year - this.DataNascimento.Year;

        #endregion
    }
}
