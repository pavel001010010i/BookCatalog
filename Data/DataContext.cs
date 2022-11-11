using Application.Interfaces;
using Data.EntityTypeConfigurations;
using Domain.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Application
{
    public class DBContext : IdentityDbContext<AppUser>, IDBContext
    {
        public DBContext(DbContextOptions<DBContext> options) : base(options) 
        {
            //Database.EnsureDeleted();
            //Database.EnsureCreated();
            //Database.Migrate();
        }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.ApplyConfiguration(new BookConfiguration());
            builder.ApplyConfiguration(new CategoryConfiguration());
            base.OnModelCreating(builder);
        }

        public DbSet<Book> Books { get; set; }
        public DbSet<Category> Categories { get; set; }
    }

}