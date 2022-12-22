using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectPOO.Models
{
    /// <summary>
    /// Classe que representa um funcionario (Herda de Pessoa, e implementa IPessoa)
    /// </summary>
    public class Funcionario : Pessoa, IPessoa
    {
        #region Construtor

        /// <summary>
        /// Construtor para o funcionario
        /// </summary>
        /// <param name="email">email do funcionario</param>
        /// <param name="nome">nome do funcionario</param>
        /// <param name="password">password do funcionario</param>
        /// <param name="numeroTelemovel">numero Telemovel do funcionario</param>
        /// <param name="dataEntrada">data Nascimento do funcionario</param>
        public Funcionario(string email, string nome, string password, int numeroTelemovel, DateTime dataEntrada)
             : base(email, nome, password, numeroTelemovel)
        {
            this.DataEntrada = dataEntrada;
        }

        #endregion


        #region Propriedades

        /// <summary>
        /// Id do Funcionario
        /// </summary>
        public uint Id { get; set; }

        /// <summary>
        /// Data de criação do funcionario no sistema
        /// </summary>
        public DateTime DataEntrada { get; set; }

        #endregion
    }
}
