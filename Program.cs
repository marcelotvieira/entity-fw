using BIManager.Data;
using BIManager.Entities;
using BIManager.Models;

namespace BIManager
{
    public static class Program
    {
        private static void Main(string[] args)
        {
            using (var context = new BIManagerDataContext())
            {
                // var usuario = new Usuario
                // {
                //     NomeUsuario = "Marcelo2",
                //     Email = "contat2o@email.com",
                //     Senha = "1234",
                //     SenhaAleatoria = false,
                //     CriadoEm = DateTime.Now,
                //     AtualizadoEm = DateTime.Now,
                // };

                // var usuario2 = new
                // {
                //     NomeUsuario = "Marcelo22222",
                //     Email = "contat22222o@email.com",
                //     AtualizadoEm = DateTime.Now,
                // };

                // UsuarioHandler.CreateUsuario(context, usuario);

                // UsuarioHandler.UpdateUsuario(context, 2, usuario2);

                // UsuarioHandler.ListUsuario(context);

                // Console.WriteLine(UsuarioHandler.GetUsuario(context, 2).NomeUsuario);

                // UsuarioHandler.DeleteUsuario(context, 2);

                // UsuarioHandler.ListUsuario(context);
            }
        }



    }
}
