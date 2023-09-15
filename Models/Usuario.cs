using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using BIManage.Models;


namespace BIManager.Models
{

    public class Usuario
    {
        public int Id { get; set; }

        public string? NomeUsuario { get; set; }

        public string? Email { get; set; }

        public string? Senha { get; set; }

        public int FuncaoId { get; set; }

        public Funcao? Funcao { get; set; }

        public bool SenhaAleatoria { get; set; }

        public List<BaseDeDados>? BasesDeDados { get; set; }

        public DateTime CriadoEm { get; set; }

        public DateTime AtualizadoEm { get; set; }
    }
}