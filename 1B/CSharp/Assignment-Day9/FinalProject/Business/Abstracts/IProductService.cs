using System;
using Entities.Concretes;

namespace Business.Abstracts
{
	public interface IProductService
	{
		List<Product> GetAll();
		List<Product> GetAllByCategoryId(int id);
		List<Product> GetByUnitPrice(decimal min, decimal max);
	}
}

