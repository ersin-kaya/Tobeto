using System;
using Tobeto.Core.Persistence.Repositories;

namespace Domain.Entities
{
	public class Brand : Entity<Guid>
	{
		public string Name { get; set; }
	}
}

