using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectPOO.Exceptions
{
    public class ItemIsNullException : Exception
    {
        /// <summary>
        /// Construtor para a exception ItemIsNullException
        /// </summary>
        /// <param name="source">source recebida</param>
        public ItemIsNullException(string source)
        {
            this.Source = source;
        }

        /// <summary>
        /// Mensagem a mostrar
        /// </summary>
        public override string Message => "O item recebido é null!";
    }
}
