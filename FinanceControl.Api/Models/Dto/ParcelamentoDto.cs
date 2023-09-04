namespace FinanceControl.Api.Models.Dto
{
    public class ParcelamentoDto
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public int CodCartao { get; set; }
        public decimal ValorTotalCompra { get; set; }
        public short QuantidadeParcelas { get; set; }
        public DateTime DataCompra { get; set; }
        public string Responsavel { get; set; }
    }
}
