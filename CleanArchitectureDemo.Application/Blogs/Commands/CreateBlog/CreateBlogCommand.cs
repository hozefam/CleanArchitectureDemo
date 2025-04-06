using CleanArchitectureDemo.Application.Blogs.Queries.GetBlogs;
using MediatR;

namespace CleanArchitectureDemo.Application.Blogs.Commands.CreateBlog
{
	public record CreateBlogCommand(string Title, string Content, string Author) : IRequest<BlogVM>;
}
