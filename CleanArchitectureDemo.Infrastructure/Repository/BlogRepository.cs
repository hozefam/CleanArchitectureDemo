using CleanArchitectureDemo.Domain.Entity;
using CleanArchitectureDemo.Domain.Repository;
using CleanArchitectureDemo.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;

namespace CleanArchitectureDemo.Infrastructure.Repository
{
	public class BlogRepository : IBlogRepository
	{
		private readonly BlogDbContext _blogDbContext;

		public BlogRepository(BlogDbContext blogDbContext)
		{
			this._blogDbContext = blogDbContext;
		}

		public async Task<Blog> CreateAsync(Blog blog)
		{
			await _blogDbContext.Blogs.AddAsync(blog);
			await _blogDbContext.SaveChangesAsync();

			return blog;
		}

		public async Task<int> DeleteAsync(int id)
		{
			return await _blogDbContext.Blogs.Where(b => b.Id == id).ExecuteDeleteAsync();
		}

		public async Task<List<Blog>> GetAllAsync()
		{
			return await _blogDbContext.Blogs.AsNoTracking().ToListAsync();
		}

		public Task<Blog?> GetByIdAsync(int id)
		{
			return _blogDbContext.Blogs.AsNoTracking().FirstOrDefaultAsync(b => b.Id == id);
		}

		public async Task<int> UpdateAsync(int id, Blog blog)
		{
			return await _blogDbContext.Blogs.Where(b => b.Id == id).ExecuteUpdateAsync(setters => setters
				.SetProperty(b => b.Title, blog.Title)
				.SetProperty(b => b.Content, blog.Content)
				.SetProperty(b => b.Author, blog.Author));
		}
	}
}
