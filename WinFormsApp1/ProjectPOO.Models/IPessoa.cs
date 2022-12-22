using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectPOO.Models
{
    public interface IPessoa
    {
        #region Propriedades

        /// <summary>
        /// Id de Pessoa
        /// </summary>
        uint Id { get; set; }

        /// <summary>
        /// Email de Pessoa
        /// </summary>
        string Email { get; set; }

        /// <summary>
        /// Nome de Pessoa
        /// </summary>
        string Nome { get; set; }

        /// <summary>
        /// Password de Pessoa
        /// </summary>
        string Password { get; set; }

        /// <summary>
        /// Numero Telemovel de Pessoa
        /// </summary>
        int NumeroTelemovel { get; set; }

        #endregion
    }
}
