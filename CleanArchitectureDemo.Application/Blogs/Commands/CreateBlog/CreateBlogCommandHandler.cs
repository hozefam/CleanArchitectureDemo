using AutoMapper;
using CleanArchitectureDemo.Application.Blogs.Queries.GetBlogs;
using CleanArchitectureDemo.Domain.Entity;
using CleanArchitectureDemo.Domain.Repository;
using MediatR;

namespace CleanArchitectureDemo.Application.Blogs.Commands.CreateBlog
{
	public class CreateBlogCommandHandler : IRequestHandler<CreateBlogCommand, BlogVM>
	{
		private readonly IBlogRepository _repository;
		private readonly IMapper _mapper;

		public CreateBlogCommandHandler(IBlogRepository repository, IMapper mapper)
		{
			this._repository = repository;
			this._mapper = mapper;
		}

		public async Task<BlogVM> Handle(CreateBlogCommand request, CancellationToken cancellationToken)
		{
			Blog blogEntity = new() { Author = request.Author, Content = request.Content, Title = request.Title };

			var result = await _repository.CreateAsync(blogEntity);

			return _mapper.Map<BlogVM>(result);
		}
	}
}
