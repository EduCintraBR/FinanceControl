using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FinanceControl.Api.Models
{
    public class Controle
    {
        public int Id { get; set; }

        public short Mes { get; set; }

        public short Ano { get; set; }

        public IEnumerable<Ganhos> ListaGanhos { get; set; }

        public IEnumerable<Custos> ListaCustos { get; set; }
    }

}
