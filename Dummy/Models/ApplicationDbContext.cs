using System.Data.Entity;

namespace Dummy.Models
{
	public class ApplicationDbContext : DbContext
	{
		public DbSet<Customers> Customers { get; set; }
		public DbSet<Movies> Movies { get; set; }
	}
}
