using CleanArchitectureDemo.Application.Blogs.Queries.GetBlogs;
using MediatR;

namespace CleanArchitectureDemo.Application.Blogs.Queries.GetBlogById
{
	public record GetBlogByIdQuery(int BlogId) : IRequest<BlogVM>;
}
