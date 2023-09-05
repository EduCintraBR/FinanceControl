namespace FinanceControl.Api.Models.Dto
{
    public class GanhosDto
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string CategoriaOrigem { get; set; }
        public decimal Valor { get; set; }
        public bool EhFixo { get; set; }
    }
}
