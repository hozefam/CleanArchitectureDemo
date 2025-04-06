using CleanArchitectureDemo.Application.Common.Mappings;
using CleanArchitectureDemo.Domain.Entity;

namespace CleanArchitectureDemo.Application.Blogs.Queries.GetBlogs
{
	public record BlogVM(int Id, string Title, string Content, string Author) : IMapFrom<Blog>;
}
