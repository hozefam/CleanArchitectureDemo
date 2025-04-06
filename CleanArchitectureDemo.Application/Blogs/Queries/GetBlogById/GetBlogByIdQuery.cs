using CleanArchitectureDemo.Application.Blogs.Queries.GetBlogs;
using MediatR;

namespace CleanArchitectureDemo.Application.Blogs.Queries.GetBlogById
{
	public class GetBlogByIdQuery : IRequest<BlogVM>
	{
		public int BlogId { get; set; }
	}
}
