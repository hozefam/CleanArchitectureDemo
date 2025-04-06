using CleanArchitectureDemo.Domain.Entity;

namespace CleanArchitectureDemo.Domain.Repository
{
	public interface IBlogRepository
	{
		Task<List<Blog>> GetAllAsync();
		Task<Blog?> GetByIdAsync(int id);
		Task<Blog> CreateAsync(Blog blog);
		Task<int> UpdateAsync(int id, Blog blog);
		Task<bool> DeleteAsync(int id);
	}
}
