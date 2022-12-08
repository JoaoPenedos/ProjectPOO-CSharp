using ProjectPOO.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectPOO.Models
{
    public class Pagamento
    {
        private readonly int lastPagamentoID = -1;

        public Pagamento(double montante, DateTime dataEmissao, DateTime dataPagamento = default, string descricao = "")
        {
            this.PagamentoID = lastPagamentoID + 1;
            this.Montante = montante;
            this.DataEmissao = dataEmissao;
            this.DataPagamento = dataPagamento;
            this.Descricao = descricao;
            this.EstadoPagamento = EstadoPagamento.NaoPago;
        }

        public int PagamentoID { get; private set; }

        public double Montante { get; set; }

        public DateTime DataEmissao { get; private set; }

        public DateTime DataPagamento { get; set; }

        public string Descricao { get; set; }

        public EstadoPagamento EstadoPagamento { get; private set; }


        public void PagarPagamentoPendente() => this.EstadoPagamento = EstadoPagamento.Pago;
    }
}
