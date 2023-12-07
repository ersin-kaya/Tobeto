using System;
using Domain.Entities;

namespace Application.Services.Repositories
{
	public interface ICategoryRepository : IRepository<Category, Guid>, IAsyncRepository<Category, Guid>
	{
	}
}

