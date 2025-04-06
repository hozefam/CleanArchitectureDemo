using CleanArchitectureDemo.Domain.Repository;
using CleanArchitectureDemo.Infrastructure.Data;
using CleanArchitectureDemo.Infrastructure.Repository;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace CleanArchitectureDemo.Infrastructure
{
	public static class ConfigureServices
	{
		private const string connectionName = "BlogDbConnection";

		public static IServiceCollection AddInfrastructureServices(this IServiceCollection services, IConfiguration configuration)
		{
			services.AddDbContext<BlogDbContext>(options =>
			{
				options.UseSqlite(configuration.GetConnectionString(connectionName) ??
					throw new InvalidOperationException($"Connection string {connectionName} not found"));
			});

			services.AddTransient<IBlogRepository, BlogRepository>();

			return services;
		}
	}
}
