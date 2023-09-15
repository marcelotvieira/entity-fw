using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BIManager.Models
{

    public class Funcao
    {

        public int Id { get; set; }

        public string? Nome { get; set; }

        public List<Usuario>? Usuarios { get; set; }
    }
}