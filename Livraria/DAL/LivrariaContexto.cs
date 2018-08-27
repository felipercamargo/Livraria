using Livraria.Models;
using System.Data.Entity;

namespace Livraria.DAL
{
    public class LivrariaContexto : DbContext
    {
        public LivrariaContexto() :
            base("LivrariaContexto")
        { }

        public DbSet<Livro> Livros { get; set; }
        public DbSet<Categoria> Categorias { get; set; }
        
    }
}