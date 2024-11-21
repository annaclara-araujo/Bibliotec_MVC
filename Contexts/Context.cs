using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Bibliotec.Models;
using Microsoft.EntityFrameworkCore;

namespace Bibliotec.Contexts
{
    //Classe que tera as informações do banco de dados
    public class Context : DbContext
    {
        //criar metodo construtor
        public Context()
        {

        }

        public Context(DbContextOptions<Context> options) : base(options)
        {

        }

        //OnConfiguring - Possui a configuracao da conexao com o banco de dados

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)

        {
            //colocar as informacoes do banco
            if (!optionsBuilder.IsConfigured)
            {
                //a string de conexao do banco de dados
                // Data Source - Nome do servidor do banco de dados
                // initial Catalog - nome do banco 
                // User Id e PassWord - informacoes de acesso ao servidor do banco de dados
                optionsBuilder.UseSqlServer("Data Source = NOTE40-S28\\SQLEXPRESS; Initial Catalog = Bibliotec; User Id=sa; Password=123; Integrated Security=true; TrustServerCertificate = true");

            }
        }

        // As referencias das nossas tabelas no banco de dados:
        public DbSet<Categoria> Categoria { get; set; }
        public DbSet<Curso> Curso { get; set; }
        public DbSet<Livro> Livro { get; set; }
        public DbSet<Usuario> Usuario { get; set; }
        public DbSet<LivroCategoria> LivroCategoria { get; set; }
        public DbSet<LivroReserva> LivroReserva { get; set; }



    }
}