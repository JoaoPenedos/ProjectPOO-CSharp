using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectPOO.Models
{
    public abstract class Pessoa
    {
        #region Construtor

        /// <summary>
        /// Construtor para o Pessoa
        /// </summary>
        /// <param name="email">email da Pessoa</param>
        /// <param name="nome">nome da Pessoa</param>
        /// <param name="password">password da Pessoa</param>
        /// <param name="numeroTelemovel">numero Telemovel da Pessoa</param>
        public Pessoa(string email, string nome, string password, int numeroTelemovel)
        {
            this.Email = email;
            this.Nome = nome;
            this.Password = password;
            this.NumeroTelemovel = numeroTelemovel;
        }

        #endregion


        #region MyRegion

        /// <summary>
        /// Email de Pessoa
        /// </summary>
        public string Email { get; set; }

        /// <summary>
        /// Nome de Pessoa
        /// </summary>
        public string Nome { get; set; }

        /// <summary>
        /// Password de Pessoa
        /// </summary>
        public string Password { get; set; }

        /// <summary>
        /// Numero Telemovel de Pessoa
        /// </summary>
        public int NumeroTelemovel { get; set; }

        #endregion
    }
}
