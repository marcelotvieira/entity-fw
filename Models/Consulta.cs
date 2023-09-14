using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BIManager.Models
{
    [Table("Consulta")]
    public class Consulta
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required]
        [MaxLength(80)]
        public string? Nome { get; set; }

        [Required]
        public string? ConsultaSQL { get; set; }

        [Required]
        [DefaultValue(false)]
        public bool CompativelComPeriodo { get; set; }

        [MaxLength(30)]
        public string? ChaveEixoYDoGrafico { get; set; }

        [MaxLength(30)]

        public string? ChaveEixoXDoGrafico { get; set; }
    }
}