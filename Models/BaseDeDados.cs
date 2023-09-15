using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using BIManager.Models;

namespace BIManage.Models
{
    public class BaseDeDados
    {

        public int Id { get; set; }

        public string? Nome { get; set; }

        public string? UrlConexao { get; set; }

        public int UsuarioId { get; set; }

        public Usuario? Usuario { get; set; }

        public ICollection<ConsultaBaseDeDados>? Consultas { get; set; }

        public DateTime CriadoEm { get; set; }

        public DateTime AtualizadoEm { get; set; }

    }
}