using BIManager.Data;
using BIManager.Models;

namespace BIManager
{
    public static class Program
    {
        private static void Main(string[] args)
        {
            using (var context = new BIManagerDataContext())
            {
                var Usuario = new Usuario
                {
                    NomeUsuario = "Marcelo",
                    Email = "contato@email.com",
                    Senha = "123",
                    SenhaAleatoria = false,
                    CriadoEm = DateTime.Now,
                    AtualizadoEm = DateTime.Now,
                };

                context.Usuarios.Add(Usuario);
                context.SaveChanges();
            }
        }
    }
}
