using BIManage.Models;
using BIManager.Data;
using BIManager.Models;
using Microsoft.EntityFrameworkCore;

namespace BIManager
{
    public static class Program
    {
        private static void Main(string[] args)
        {
            var usuario = new Usuario
            {
                NomeUsuario = "MArcelo",
                Email = "contato2@email.com",
                Senha = "1233",
                BasesDeDados = new List<BaseDeDados> { new BaseDeDados {
                    Nome = "Base 1",
                    UrlConexao = "urldeexemplo2.com",
                    }},
                SenhaAleatoria = true,
            };

            using (var ctx = new BIManagerDataContext())
            {
                var role = ctx.Funcao.FirstOrDefault(x => x.Nome == "User");
                if (role == null)
                    return;

                usuario.Funcao = role;
                ctx.Usuarios.Add(usuario);
                ctx.SaveChanges();

                var usuarios = ctx.Usuarios.Include(x => x.BasesDeDados).Include(x => x.Funcao).AsNoTracking().ToList();
                var funcoes = ctx.Funcao.ToList();
                var bases = ctx.BasesDeDados.ToList();


                foreach (var user in usuarios)
                    Console.WriteLine($"{user.NomeUsuario} - {user.Email} - {user.Funcao?.Nome}");

                foreach (var funcao in funcoes)
                    Console.WriteLine(funcao.Nome);

                foreach (var baseDeDados in bases)
                    Console.WriteLine(baseDeDados.Nome);
            }



        }
    }
}
