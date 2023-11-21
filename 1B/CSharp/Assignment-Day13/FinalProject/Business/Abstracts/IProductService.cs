using Core.Utilities.Results.Abstracts;
using Entities.Concretes;
using Entities.DTOs;

namespace Business.Abstracts
{
    public interface IProductService
	{
		IDataResult<List<Product>> GetAll();
        IDataResult<List<Product>> GetAllByCategoryId(int id);
		IDataResult<Product> GetById(int id);
		IDataResult<List<Product>> GetByUnitPrice(decimal min, decimal max);
        IDataResult<List<ProductDetailDTO>> GetProductDetails();
        IResult Add(Product product);
		IResult Update(Product product);
		IResult Delete(Product product);
    }
}

