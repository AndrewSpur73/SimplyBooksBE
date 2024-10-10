using SimplyBooksBE.Models;
using SimplyBooksBE.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Hosting;

namespace SimplyBooksBE
{
    public class SimplyBooksBEDbContext : DbContext
    {
        public DbSet<Author> Authors { get; set; }
        public DbSet<Book> Books { get; set; }

        public SimplyBooksBEDbContext(DbContextOptions<SimplyBooksBEDbContext> context) : base(context)
        {

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            //Seed data for the application
            modelBuilder.Entity<Author>().HasData(AuthorData.Authors);
            modelBuilder.Entity<Book>().HasData(BookData.Books);

            modelBuilder.Entity<Author>()
                .HasMany(a => a.Books)
                .WithOne(b => b.Author)
                .HasForeignKey(b => b.AuthorId)
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
