namespace FinanceControl.Api.Models
{
    public class Ganhos
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public Categoria CategoriaOrigem { get; set; }
        public decimal Valor { get; set; }
        public bool EhFixo { get; set; }
    }
}
