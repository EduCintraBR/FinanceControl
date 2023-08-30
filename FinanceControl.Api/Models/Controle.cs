using System.ComponentModel.DataAnnotations;

namespace FinanceControl.Api.Models
{
    public class Controle
    {
        public int Id { get; set; }
        public IEnumerable<Ganhos> Ganhos { get; set; }
        public IEnumerable<Custos> Custos { get; set; }
        [Range(1,12)]
        public short Mes { get; set; }
        [Range(1,2999)]
        public short Ano { get; set; }
    }
}
