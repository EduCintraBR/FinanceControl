using FinanceControl.Api.Models.Enums;

namespace FinanceControl.Api.Models
{
    public class Categoria
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public TipoCategoria Tipo { get; set; }
    }
}
