using Microsoft.EntityFrameworkCore;

namespace ODataBookStore.EDM
{
	public class ApplicationDbContext : DbContext
	{
		public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
			: base(options)
		{
		}

		public DbSet<Book> Books { get; set; }
		public DbSet<Press> Presses { get; set; }

		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			modelBuilder.Entity<Book>().HasKey(b => b.Id);
			modelBuilder.Entity<Press>().HasKey(p => p.Id);
			modelBuilder.Entity<Book>()
				.OwnsOne(b => b.Location);
		}
	}
}
