using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BIManager.Models
{

    [Table("Usuario")]
    public class Usuario
    {
        [Key]
        public int Id { get; set; }
        public string? NomeUsuario { get; set; }
        public string? Email { get; set; }
        public string? Senha { get; set; }
        public int FuncaoId { get; set; }
        public bool SenhaAleatoria { get; set; }
        public DateTime CriadoEm { get; set; }
        public DateTime AtualizadoEm { get; set; }
    }
}