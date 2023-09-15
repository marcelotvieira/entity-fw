using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using BIManage.Models;

namespace BIManager.Models
{

    public class Consulta
    {

        public int Id { get; set; }

        public string? Nome { get; set; }

        public string? ConsultaSQL { get; set; }

        public bool CompativelComPeriodo { get; set; }

        public string? ChaveEixoYDoGrafico { get; set; }

        public List<BaseDeDados>? BasesDeDados { get; set; }

        public string? ChaveEixoXDoGrafico { get; set; }
    }
}