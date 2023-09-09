namespace FinanceControl.Api.Models
{
    public class Ganhos
    {
        public int Id { get; set; }
        public int CodControle { get; set; }
        public string Nome { get; set; }
        public string CategoriaOrigem { get; set; }
        public decimal Valor { get; set; }
        public bool EhFixo { get; set; }

        public Controle Controle { get; set; }
    }
}
