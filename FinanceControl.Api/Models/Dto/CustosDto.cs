namespace FinanceControl.Api.Models.Dto
{
    public class CustosDto
    {
        public int Id { get; set; }

        public string Nome { get; set; }

        public string CategoriaOrigem { get; set; }

        public decimal Valor { get; set; }

        public bool EhParcelado { get; set; }

        public int? CodParcela { get; set; }

        public int CodControle { get; set; }
    }
}
