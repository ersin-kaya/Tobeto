using System;
using Entities.Concretes;

namespace Business.Abstracts
{
	public interface IProductService
	{
		List<Product> GetAll();
	}
}

