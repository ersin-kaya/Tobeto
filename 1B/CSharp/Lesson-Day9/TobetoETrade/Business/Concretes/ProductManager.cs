using System;
using DataAccess.Concretes;
using Entities.Concretes;

namespace Business.Concretes
{
    public class ProductManager
    {
        public void Add(Product product)
        {
            AdoNetProductDal productDal = new AdoNetProductDal();
            productDal.Add(product);
        }
    }
}