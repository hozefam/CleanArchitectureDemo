﻿using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace CleanArchitectureDemo.API.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public abstract class ApiControllerBase : ControllerBase
	{
		private ISender _mediator;

		protected ISender Mediator => _mediator ??= HttpContext.RequestServices.GetRequiredService<ISender>()!;
	}
}
