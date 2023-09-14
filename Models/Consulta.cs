namespace BIManager.Models
{
    public class Consulta
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string ConsultaSQL { get; set; }
        public bool CompativelComPeriodo { get; set; }
        public string chaveEixoYDoGrafico { get; set; }
        public string chaveEixoXDoGrafico { get; set; }
    }
}