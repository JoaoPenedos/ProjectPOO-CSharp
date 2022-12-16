using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectPOO.Models
{
    public interface IPessoa
    {
        uint Id { get; set; }

        string Email { get; set; }

        string Nome { get; set; }

        string Password { get; set; }

        int NumeroTelemovel { get; set; }
    }
}
