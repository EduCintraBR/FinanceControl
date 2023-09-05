using System.ComponentModel.DataAnnotations.Schema;

namespace FinanceControl.Api.Models
{
    public class Custos
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string CategoriaOrigem { get; set; }
        public decimal Valor { get; set; }
        public bool EhParcelado { get; set; }

        [ForeignKey(nameof(Parcela))]
        public int? CodParcela { get; set; }

        public Parcela? Parcela { get; set; }
    }
}
