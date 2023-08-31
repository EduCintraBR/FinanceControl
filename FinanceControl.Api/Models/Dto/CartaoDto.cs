namespace FinanceControl.Api.Models.Dto
{
    public class CartaoDto
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string NomeBanco { get; set; }
        public string NomeProprietario { get; set; }
        public int LimiteCartao { get; set; }
    }
}
