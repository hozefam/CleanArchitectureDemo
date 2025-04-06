using AutoMapper;
using CleanArchitectureDemo.Domain.Repository;
using MediatR;

namespace CleanArchitectureDemo.Application.Blogs.Commands.DeleteBlog
{
	public class DeleteBlogCommandHandler : IRequestHandler<DeleteBlogCommand, int>
	{
		private readonly IBlogRepository _repository;
		private readonly IMapper _mapper;

		public DeleteBlogCommandHandler(IBlogRepository repository, IMapper mapper)
		{
			this._repository = repository;
			this._mapper = mapper;
		}

		public async Task<int> Handle(DeleteBlogCommand request, CancellationToken cancellationToken)
		{
			return await _repository.DeleteAsync(request.Id);
		}
	}
}
