using System;
using Entities.Concretes;

namespace DataAccess.Abstracts
{
	//default olarak interface'in kendisi internal'dır, operasyonları public'tir
	public interface IProductDal
	{
		List<Product> GetAll();
        void Add(Product product);
		void Update(Product product);
		void Delete(Product product);
        List<Product> GetAllByCategory(int categoryId);
    }
}

