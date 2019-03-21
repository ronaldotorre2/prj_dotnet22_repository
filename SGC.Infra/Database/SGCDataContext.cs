using Microsoft.EntityFrameworkCore;
using SGC.Domain.Entities;

namespace SGC.Infra.Database
{
	/// <summary>
    /// Controle de aceso a dados
    /// </summary>
    public class SGCDataContext : DbContext
    {
        public SGCDataContext(DbContextOptions<SGCDataContext> options) : base(options) { }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsbuilder) { }

        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }
    }
}