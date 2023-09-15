using BIManage.Models;
using BIManager.Data;
using BIManager.Models;

namespace BIManager
{
    public static class Program
    {
        private static void Main(string[] args)
        {
            var usuario = new Usuario
            {
                NomeUsuario = "MArcelo2",
                Email = "contat2o@email.com",
                Funcao = new Funcao { Nome = "User" },
                Senha = "1233",
                BasesDeDados = new List<BaseDeDados> { new BaseDeDados {
                    Nome = "Base 2",
                    UrlConexao = "urldeexemplo2.com",
                    }},
                SenhaAleatoria = true,
            };

            using (var ctx = new BIManagerDataContext())
            {
                ctx.Usuarios.Add(usuario);
                ctx.SaveChanges();

                var usuarios = ctx.Usuarios.ToList();
                var funcoes = ctx.Funcao.ToList();
                var bases = ctx.BasesDeDados.ToList();

                foreach (var user in usuarios)
                    Console.WriteLine(user.NomeUsuario);

                foreach (var funcao in funcoes)
                    Console.WriteLine(funcao.Nome);

                foreach (var baseDeDados in bases)
                    Console.WriteLine(baseDeDados.Nome);
            }



        }
    }
}
