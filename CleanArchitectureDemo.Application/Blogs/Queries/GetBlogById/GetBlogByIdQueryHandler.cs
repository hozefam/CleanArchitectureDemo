using AutoMapper;
using CleanArchitectureDemo.Application.Blogs.Queries.GetBlogs;
using CleanArchitectureDemo.Domain.Repository;
using MediatR;

namespace CleanArchitectureDemo.Application.Blogs.Queries.GetBlogById
{
	public class GetBlogByIdQueryHandler : IRequestHandler<GetBlogByIdQuery, BlogVM>
	{
		private readonly IBlogRepository _repository;
		private readonly IMapper _mapper;

		public GetBlogByIdQueryHandler(IBlogRepository repository, IMapper mapper)
		{
			this._repository = repository;
			this._mapper = mapper;
		}

		public async Task<BlogVM> Handle(GetBlogByIdQuery request, CancellationToken cancellationToken)
		{
			var blog = await _repository.GetByIdAsync(request.BlogId);

			var blogVM = _mapper.Map<BlogVM>(blog);

			return blogVM;
		}
	}
}
