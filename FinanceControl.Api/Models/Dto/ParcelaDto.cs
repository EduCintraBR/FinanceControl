using System.ComponentModel.DataAnnotations.Schema;

namespace FinanceControl.Api.Models.Dto
{
    public class ParcelaDto
    {
        public int Id { get; set; }
        public int CodParcelamento { get; set; }
        public short ParcelaAtual { get; set; }
        public short ParcelaFinal { get; set; }
        public decimal Valor { get; set; }
        public string MesAno { get; set; }
    }
}
