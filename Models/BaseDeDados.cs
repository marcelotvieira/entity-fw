namespace BIManage.Models
{
    public class BaseDeDados
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string UrlConexao { get; set; }
        public int ProprietarioId { get; set; }
        public DateTime CriadoEm { get; set; }
        public DateTime AtualizadoEm { get; set; }
    }
}