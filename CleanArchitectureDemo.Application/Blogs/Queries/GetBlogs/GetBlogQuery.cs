using MediatR;

namespace CleanArchitectureDemo.Application.Blogs.Queries.GetBlogs
{
	public record GetBlogQuery : IRequest<List<BlogVM>>;
}
