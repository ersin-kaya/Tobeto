using Business.Concretes;
using DataAccess.Concretes.EntityFramework;
using DataAccess.Concretes.InMemory;

//SOLID
//Open Closed Principle

ProductManager productManager = new ProductManager(new EfProductDal());

foreach (var product in productManager.GetByUnitPrice(50, 100))
{
    Console.WriteLine(product.ProductName);
}
