using System;
using Tobeto.Core.Persistence.Repositories;

namespace Domain.Entities
{
	public class Category : Entity<Guid>
	{
        public string Name { get; set; }
        public string Description { get; set; }

        //public List<Course>? Courses { get; set; }
    }
}

