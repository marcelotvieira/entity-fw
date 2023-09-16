using BIManage.Models;
using BIManager.Data;
using BIManager.Models;
using Microsoft.EntityFrameworkCore;

namespace BIManager
{
    public static class Program
    {
        private static async Task Main(string[] args)
        {
            // var usuario = new Usuario
            // {
            //     NomeUsuario = "MArcelo2",
            //     Email = "contato22@email.com",
            //     Senha = "12332",
            //     BasesDeDados = new List<BaseDeDados> { new BaseDeDados {
            //         Nome = "Base 1",
            //         UrlConexao = "urldeexemplo222.com",
            //         }},
            //     SenhaAleatoria = true,
            // };

            using var ctx = new BIManagerDataContext();
            // var role = await ctx.Funcao.FirstOrDefaultAsync(x => x.Nome == "User");
            // if (role == null)
            //     return;

            // usuario.Funcao = role;
            // ctx.Usuarios.Add(usuario);
            // await ctx.SaveChangesAsync();

            var usuarios = await ctx.Usuarios.Include(x => x.BasesDeDados).Include(x => x.Funcao).AsNoTracking().ToListAsync();
            var funcoes = await ctx.Funcao.AsNoTracking().ToListAsync();
            var bases = await ctx.BasesDeDados.AsNoTracking().ToListAsync();


            foreach (var user in usuarios)
                Console.WriteLine($"{user.NomeUsuario} - {user.Email} - {user.Funcao?.Nome}");

            foreach (var funcao in funcoes)
                Console.WriteLine(funcao.Nome);

            foreach (var baseDeDados in bases)
                Console.WriteLine(baseDeDados.Nome);



        }
    }
}
