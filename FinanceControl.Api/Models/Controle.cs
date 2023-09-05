using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FinanceControl.Api.Models
{
    public class Controle
    {
        public int Id { get; set; }

        [ForeignKey(nameof(Ganhos))]
        public int CodGanho { get; set; }
        public IEnumerable<Ganhos> ListaGanhos { get; set; }

        [ForeignKey(nameof(Custos))]
        public int CodCusto { get; set; }
        public IEnumerable<Custos> ListaCustos { get; set; }

        [Range(1,12)]
        public short Mes { get; set; }
        [Range(1,2999)]
        public short Ano { get; set; }
    }
}
