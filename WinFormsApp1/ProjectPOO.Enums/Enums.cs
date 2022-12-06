using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectPOO.Enums
{
    public enum EstadoViagem
    {
        NaoUsada, UsadaPaga, UsadaNaoPaga, EmEspera
    }

    public enum EstadoVeiculo
    {
        Avariado, Inativo, SemBateria, Ativo 
    }

    public enum EstadoReserva
    {
        EmEsepra, Cancelada, Utilizada, NaoValidade
    }

    public enum EstadoPagamento
    {
        Pago, NaoPago
    }

}
