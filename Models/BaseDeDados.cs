using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using BIManager.Models;

namespace BIManage.Models
{
    [Table("BaseDeDados")]
    public class BaseDeDados
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required]
        [MaxLength(80)]
        public string? Nome { get; set; }

        [Required]
        [MaxLength(255)]
        public string? UrlConexao { get; set; }

        [Required]
        [ForeignKey("UsuarioId")]
        public int UsuarioId { get; set; }

        public Usuario? Usuario { get; set; }


        public DateTime CriadoEm { get; set; }
        public DateTime AtualizadoEm { get; set; }

    }
}