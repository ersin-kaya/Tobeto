using Core.DataAccess;
using Entities.Concretes;
using Entities.DTOs;

namespace DataAccess.Abstracts
{
    //default olarak interface'in kendisi internal'dır, operasyonları public'tir
    public interface IProductDal : IEntityRepository<Product>
	{
        List<ProductDetailDTO> GetProductDetails();
    }
}

