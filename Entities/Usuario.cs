using BIManager.Data;
using BIManager.Models;
using Microsoft.EntityFrameworkCore;

namespace BIManager.Entities
{
    public static class UsuarioHandler
    {
        public static Usuario GetUsuario(BIManagerDataContext ctx, int id)
        {
            return ctx
                .Usuarios
                .AsNoTracking()
                .FirstOrDefault(x => x.Id == id) ?? throw new Exception("Usuário não encontrado");
        }

        public static void CreateUsuario(BIManagerDataContext ctx, Usuario usuario)
        {
            ctx.Usuarios.Add(usuario);
            ctx.SaveChanges();
        }

        public static void UpdateUsuario(BIManagerDataContext ctx, int id, object usuario)
        {
            var target = GetUsuario(ctx, id);
            if (usuario != null && target != null)
            {
                var usuarioProperties = usuario.GetType().GetProperties();
                foreach (var property in usuarioProperties)
                {
                    var targetProperty = target.GetType().GetProperty(property.Name);
                    if (targetProperty != null && targetProperty.CanWrite)
                    {
                        var value = property.GetValue(usuario, null);
                        targetProperty.SetValue(target, value);
                    }
                }
            }
            ctx.SaveChanges();
        }

        public static void ListUsuario(BIManagerDataContext ctx)
        {
            var rows = ctx.Usuarios.AsNoTracking().ToList();

            foreach (var row in rows)
            {
                Console.WriteLine(@$"
                {row.Id} - {row.NomeUsuario} - {row.Email}");
            }
        }

        public static void DeleteUsuario(BIManagerDataContext ctx, int id)
        {
            ctx.Usuarios.Remove(GetUsuario(ctx, id));
            ctx.SaveChanges();
        }
    }
}