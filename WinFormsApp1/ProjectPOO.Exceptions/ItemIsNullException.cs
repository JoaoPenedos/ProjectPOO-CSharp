using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectPOO.Exceptions
{
    public class ItemIsNullException : Exception
    {
        public ItemIsNullException(string source)
        {
            this.Source = source;
        }

        public override string Message => "Insira uma data aceite!";
    }
}
