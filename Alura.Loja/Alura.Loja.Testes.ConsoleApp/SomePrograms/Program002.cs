using Microsoft.EntityFrameworkCore.ChangeTracking;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alura.Loja.Testes.ConsoleApp.SomePrograms
{
    class Program002
    {
        static void OldMain2()
        {
            using (var contexto = new LojaContext())
            {
                var serviceProvider = contexto.GetInfrastructure<IServiceProvider>();
                var loggerFactory = serviceProvider.GetService<ILoggerFactory>();
                loggerFactory.AddProvider(SqlLoggerProvider.Create());

                var produtos = contexto.Produtos.ToList();

                ExibeEntries(contexto.ChangeTracker.Entries());

                //var p1 = produtos.First();
                //p1.Nome = "Censura"; // O SQL chama um Update();

                //var novoProduto = new Produto()
                //{
                //    Nome = "Desinfetante",
                //    Categoria = "Limpeza",
                //    Preco = 2.99
                //};
                //contexto.Produtos.Add(novoProduto); // O SQL chama um Insert();

                var p1 = produtos.Last();
                contexto.Produtos.Remove(p1); // O SQL chama um Delete();

                // var entry = contexto.Entry(novoProduto); // Caso adicionado e deletado antes do SaveChanges(); 
                // podemos perguntar pelo elemento dessa forma, sendo categorizado como 'Detached' pelo entry.State;

                ExibeEntries(contexto.ChangeTracker.Entries());

                contexto.SaveChanges();

                ExibeEntries(contexto.ChangeTracker.Entries());
            }
        }

        private static void ExibeEntries(IEnumerable<EntityEntry> entries)
        {
            Console.WriteLine("==========");

            foreach (var e in entries)
            {
                Console.WriteLine($"{e.Entity.ToString()} - {e.State}");
            }
        }
    }
}
