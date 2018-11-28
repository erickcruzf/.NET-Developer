using CasaDoCodigo.Models;
using CasaDoCodigo.Repositories;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.IO;

namespace CasaDoCodigo
{
    class DataService : IDataService
    {
        private readonly ApplicationContext contexto;
        private readonly IProdutoRepository produtoRepository;

        public DataService(ApplicationContext contexto, IProdutoRepository produtoRepository)
        {
            this.contexto = contexto;
            this.produtoRepository = produtoRepository;
        }

        public void InicializaDB() // Inicializa o Banco de dados se necessário.
        {
            contexto.Database.Migrate(); // Carrega o banco de dados utilizando as migrations! // evitar usar o EnsureCreated() que faz a mesma coisa porém não permite o uso de migrações após o uso.

            List<Livro> livros = GetLivros();

            produtoRepository.SaveProdutos(livros);
        }
        
        private static List<Livro> GetLivros()
        {
            var json = File.ReadAllText("livros.json");
            var livros = JsonConvert.DeserializeObject<List<Livro>>(json);
            return livros;
        }
    }
}
