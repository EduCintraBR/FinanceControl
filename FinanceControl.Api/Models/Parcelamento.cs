namespace FinanceControl.Api.Models
{
    public class Parcelamento
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public Cartao Cartao { get; set; }
        public decimal ValorTotalCompra { get; set; }
        public short QuantidadeParcelas { get; set; }
        public DateTime DataCompra { get; set; }
        public string Responsavel { get; set; }
    }
}
