using System.ComponentModel.DataAnnotations.Schema;

namespace BIManager.Models
{
    [Table("ConsultaBaseDeDados")]
    public class ConsultaBaseDeDados
    {
        public int BaseDeDadosId { get; set; }
        public int ConsultaId { get; set; }
    }
}