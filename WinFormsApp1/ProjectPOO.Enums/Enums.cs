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

    public enum EstadoPagamento
    {
        Pago, NaoPago
    }

    public enum EstadoReserva
    {
        EmEspera, Cancelada, Utilizada, NaoValidade
    }

    public enum EstadoVeiculo
    {
        Avariado, Inativo, SemBateria, Ativo, Reservado
    }

    public enum TipoVeiculo
    {
        Bicicleta, Trotinete
    }
}
