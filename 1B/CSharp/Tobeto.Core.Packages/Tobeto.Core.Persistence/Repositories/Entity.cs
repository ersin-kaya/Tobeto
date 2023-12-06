using System;
namespace Tobeto.Core.Persistence.Repositories
{
	public class Entity<TId> : IEntityTimestamps
	{
		public TId Id { get; set; }

        public DateTime CreatedDate { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public DateTime? DeletedDate { get; set; }
    }
}

