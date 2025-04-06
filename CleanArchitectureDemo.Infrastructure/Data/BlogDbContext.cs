using CleanArchitectureDemo.Domain.Entity;
using Microsoft.EntityFrameworkCore;

namespace CleanArchitectureDemo.Infrastructure.Data
{
	public class BlogDbContext : DbContext
	{
		public BlogDbContext(DbContextOptions<BlogDbContext> dbContextOptions) : base(dbContextOptions)
		{
		}

		public DbSet<Blog> Blogs { get; set; }
	}
}
