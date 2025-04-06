using MediatR;

namespace CleanArchitectureDemo.Application.Blogs.Commands.UpdateBlog
{
	public record UpdateBlogCommand(int Id, string Title, string Content, string Author) : IRequest<int>;
}
