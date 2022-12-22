using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectPOO.Exceptions
{
    public class ItemDoesNotExistsException : Exception
    {
        /// <summary>
        /// Construtor para a exception ItemDoesNotExistsException
        /// </summary>
        /// <param name="source">source recebida</param>
        public ItemDoesNotExistsException(string source)
        {
            this.Source = source;
        }

        /// <summary>
        /// Mensagem a mostrar
        /// </summary>
        public override string Message => "O item recebido não existe na lista procurada!";
    }
}
