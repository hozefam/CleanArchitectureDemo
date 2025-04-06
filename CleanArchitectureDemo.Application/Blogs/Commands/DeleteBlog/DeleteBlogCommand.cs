using MediatR;

namespace CleanArchitectureDemo.Application.Blogs.Commands.DeleteBlog
{
	public record DeleteBlogCommand(int Id) : IRequest<int>;
}
