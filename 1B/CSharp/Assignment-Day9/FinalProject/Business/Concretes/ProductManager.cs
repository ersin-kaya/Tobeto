using System;
using Business.Abstracts;
using DataAccess.Abstracts;
using Entities.Concretes;

namespace Business.Concretes
{
    //kural: bir iş sınıfı başka sınıfları new'lemez

    public class ProductManager : IProductService
    {
        IProductDal _productDal;

        public ProductManager(IProductDal productDal)
        {
            _productDal = productDal;
        }

        public List<Product> GetAll()
        {
            //Business rules
            return _productDal.GetAll();
        }
    }
}

