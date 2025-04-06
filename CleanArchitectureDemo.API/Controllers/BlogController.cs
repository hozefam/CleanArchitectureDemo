using CleanArchitectureDemo.Application.Blogs.Queries.GetBlogs;
using Microsoft.AspNetCore.Mvc;

namespace CleanArchitectureDemo.API.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class BlogController : ApiControllerBase
	{
		[HttpGet]
		public async Task<IActionResult> GetAllAsync()
		{
			var blogs = await Mediator.Send(new GetBlogQuery());
			return Ok(blogs);
		}
	}
}
