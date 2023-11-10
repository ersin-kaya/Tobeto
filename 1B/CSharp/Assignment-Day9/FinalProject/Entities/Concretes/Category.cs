using System;
using Entities.Abstracts;

namespace Entities.Concretes
{
	public class Category : IEntity
	{
		public int CategoryId { get; set; }
		public string CategoryName { get; set; }
	}
}

