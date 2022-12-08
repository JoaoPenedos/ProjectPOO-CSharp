using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectPOO.Models
{
    public class Posto
    {
        private readonly int lastPostoID = -1;

        public Posto(string localizacao) 
        {
            this.PostoID = lastPostoID + 1;
            this.Localizacao = localizacao;
        }

        public int PostoID { get; private set; }

        public string Localizacao { get; set; }
    }
}
