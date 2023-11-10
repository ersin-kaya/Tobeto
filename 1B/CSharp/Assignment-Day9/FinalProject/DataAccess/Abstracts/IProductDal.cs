using System;
using Entities.Concretes;

namespace DataAccess.Abstracts
{
	//default olarak interface'in kendisi internal'dır, operasyonları public'tir
	public interface IProductDal : IEntityRepository<Product>
	{
    }
}

