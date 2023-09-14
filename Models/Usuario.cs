using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BIManager.Models
{

    [Table("Usuario")]
    public class Usuario
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required]
        [MaxLength(80)]
        public string? NomeUsuario { get; set; }

        [Required]
        public string? Email { get; set; }

        [Required]
        [MaxLength(80)]
        public string? Senha { get; set; }

        [Required]
        [DefaultValue(2)]
        [ForeignKey("FuncaoId")]
        public int FuncaoId { get; set; }

        public Funcao? Funcao { get; set; }

        [Required]
        [DefaultValue(true)]
        public bool SenhaAleatoria { get; set; }

        public DateTime CriadoEm { get; set; }

        public DateTime AtualizadoEm { get; set; }

    }
}