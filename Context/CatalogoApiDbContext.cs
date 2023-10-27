using CatalogoApi.Models;
using Microsoft.EntityFrameworkCore;

namespace CatalogoApi.Context
{
    public class CatalogoApiDbContext : DbContext
    {

        public CatalogoApiDbContext(DbContextOptions<CatalogoApiDbContext> options) : base(options) 
        
        { }

        public DbSet<Categoria>? Categorias { get; set; }  
        public DbSet<Produto>? Produto { get; set; } 
    }
}
