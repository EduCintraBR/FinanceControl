namespace FinanceControl.Api.Models
{
    public class Custos
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public Categoria CategoriaOrigem { get; set; }
        public decimal Valor { get; set; }
        public bool EhParcelado { get; set; }
        public Parcela? Parcela { get; set; }
    }
}
