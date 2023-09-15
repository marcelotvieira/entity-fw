using System.ComponentModel.DataAnnotations.Schema;
using BIManage.Models;

namespace BIManager.Models
{
    [Table("ConsultaBaseDeDados")]
    public class ConsultaBaseDeDados
    {
        public int BaseDeDadosId { get; set; }
        public BaseDeDados? BaseDeDados { get; set; }
        public int ConsultaId { get; set; }
        public Consulta? Consulta { get; set; }
    }
}