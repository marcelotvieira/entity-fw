﻿using BIManager.Data;
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
                var usuario = new Usuario
                {
                    NomeUsuario = "Marcelo",
                    Email = "contato@email.com",
                    Funcao = new Funcao { Nome = "Admin", Status = true },
                    Senha = "123",
                    SenhaAleatoria = true,
                };

                // UsuarioHandler.CreateUsuario(
                //     context,
                //     usuario
                // );

                UsuarioHandler.ListUsuario(context);

                var funcoes = context.Funcao.ToList();

                foreach (var funcao in funcoes)
                    Console.WriteLine($"Nome: {funcao.Nome}\nStatus: {funcao.Status}");
            }
        }



    }
}
