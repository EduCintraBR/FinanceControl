using System.ComponentModel.DataAnnotations.Schema;

namespace FinanceControl.Api.Models
{
    public class Parcelamento
    {
        public int Id { get; set; }
        public string Nome { get; set; }

        [ForeignKey(nameof(Cartao))]
        public int CodCartao { get; set; }

        public decimal ValorTotalCompra { get; set; }
        public short QuantidadeParcelas { get; set; }
        public DateTime DataCompra { get; set; }
        public string Responsavel { get; set; }

        public Cartao Cartao { get; set; }
        public ICollection<Parcela> Parcelas { get; set; }
    }
}
