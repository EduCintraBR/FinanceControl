using System.ComponentModel.DataAnnotations.Schema;

namespace FinanceControl.Api.Models
{
    public class Ganhos
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string CategoriaOrigem { get; set; }
        public decimal Valor { get; set; }
        public bool EhFixo { get; set; }

        [ForeignKey(nameof(Controle))]
        public int CodControle { get; set; }
        public Controle Controle { get; set; }
    }
}
