namespace FinanceControl.Api.Models
{
    public class Cartao
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string NomeBanco { get; set; }
        public string NomeProprietario { get; set; }
        public int LimiteCartao { get; set; }
    }
}
