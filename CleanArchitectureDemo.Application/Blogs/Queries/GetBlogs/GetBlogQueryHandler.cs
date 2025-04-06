using MediatR;
using AutoMapper;
using CleanArchitectureDemo.Domain.Repository;

namespace CleanArchitectureDemo.Application.Blogs.Queries.GetBlogs
{
	public class GetBlogQueryHandler : IRequestHandler<GetBlogQuery, List<BlogVM>>
	{
		private readonly IBlogRepository _repository;
		private readonly IMapper _mapper;

		public GetBlogQueryHandler(IBlogRepository repository, IMapper mapper)
		{
			this._repository = repository;
			this._mapper = mapper;
		}

		public async Task<List<BlogVM>> Handle(GetBlogQuery request, CancellationToken cancellationToken)
		{
			var blogs = await _repository.GetAllAsync();

			var blogVMs = _mapper.Map<List<BlogVM>>(blogs);

			return blogVMs;
		}
	}
}
