using System;
using Entities.Concretes;

namespace DataAccess.Concretes
{
    public class AdoNetProductDal
    {
        public void Add(Product product)
        {
            Console.WriteLine("AdoNet eklendi " + product.Name);
        }
    }
}