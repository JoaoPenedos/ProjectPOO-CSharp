using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectPOO.Enums
{
    /// <summary>
    /// Enumerador para o estado da viagem
    /// </summary>
    public enum EstadoViagem
    {
        NaoUsada, UsadaPaga, UsadaNaoPaga, EmEspera
    }

    /// <summary>
    /// Enumerador para o estado do pagamento
    /// </summary>
    public enum EstadoPagamento
    {
        Pago, NaoPago
    }

    /// <summary>
    /// Enumerador para o estado da reserva
    /// </summary>
    public enum EstadoReserva
    {
        EmEspera, Cancelada, Utilizada, NaoValidade
    }

    /// <summary>
    /// Enumerador para o estado do veiculo
    /// </summary>
    public enum EstadoVeiculo
    {
        Avariado, Inativo, SemBateria, Ativo, Reservado
    }

    /// <summary>
    /// Enumerador para o tipo de veiculo
    /// </summary>
    public enum TipoVeiculo
    {
        Bicicleta, Trotinete
    }
}
