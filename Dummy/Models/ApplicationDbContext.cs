using System.Data.Entity;

namespace Dummy.Models
{
	public class ApplicationDbContext : DbContext
	{
		public DbSet<Customers> Customers { get; set; }
		public DbSet<Movies> Movies { get; set; }

		public DbSet<MembershipType> MemberShipTypes { get; set; }
		public DbSet<Genre> Genres { get; set; }
	}
}
