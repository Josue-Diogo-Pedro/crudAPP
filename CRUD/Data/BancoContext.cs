using CRUD.Models;
using Microsoft.EntityFrameworkCore;

namespace CRUD.Data
{
    public class BancoContext : DbContext
    {
        public BancoContext(DbContextOptions<BancoContext> dbContext) : base(dbContext)
        {
        }

        public DbSet<Usuario>? Usuarios { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Usuario>(model =>
            {
                model.ToTable("tbUsuario");
                model.HasKey(x => x.Id);
                model.Property(x => x.Nome).HasMaxLength(50).IsRequired();
                model.Property(x => x.Email).HasMaxLength(50);
                model.Property(x => x.Telemovel).HasMaxLength(20);
            });
        }
    }
}
