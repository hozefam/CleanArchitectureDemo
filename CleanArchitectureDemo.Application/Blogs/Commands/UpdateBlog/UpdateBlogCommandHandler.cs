using AutoMapper;
using CleanArchitectureDemo.Domain.Entity;
using CleanArchitectureDemo.Domain.Repository;
using MediatR;

namespace CleanArchitectureDemo.Application.Blogs.Commands.UpdateBlog
{
	public class UpdateBlogCommandHandler : IRequestHandler<UpdateBlogCommand, int>
	{
		private readonly IBlogRepository _repository;
		private readonly IMapper _mapper;

		public UpdateBlogCommandHandler(IBlogRepository repository, IMapper mapper)
		{
			this._repository = repository;
			this._mapper = mapper;
		}

		public async Task<int> Handle(UpdateBlogCommand request, CancellationToken cancellationToken)
		{
			var updateBlogEntry = _mapper.Map<Blog>(request);

			return await _repository.UpdateAsync(request.Id, updateBlogEntry);
		}
	}
}
