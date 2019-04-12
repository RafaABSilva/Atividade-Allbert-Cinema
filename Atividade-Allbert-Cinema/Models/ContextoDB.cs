using MySql.Data.Entity;
using System.Data.Entity;

namespace Atividade_Allbert_Cinema.Models
{
    public class ContextoDB : DbContext
    {
        public ContextoDB()
        //Reference the name of your connection string ( WebAppCon )
        : base("StringConexaoBD") { }
        public DbSet<Categorias> Categorias { get; set; }
        public DbSet<Exibicoes> Exibicoes { get; set; }
        public DbSet<Filmes> Filmes { get; set; }
        public DbSet<Salas> Salas { get; set; }

    }
}