using Microsoft.EntityFrameworkCore;
using App.Models;
namespace App.Context
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }
        public DbSet<Categoria> Categorias { get; set; }
        public DbSet<Serie> Series { get; set; }

        public DbSet<Usuario> Usuarios { get; set;}
    }
}