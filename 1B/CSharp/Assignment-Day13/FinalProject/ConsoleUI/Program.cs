using Business.Concretes;
using DataAccess.Concretes.EntityFramework;

//SOLID
//Open Closed Principle

ProductManager productManager = new ProductManager(new EfProductDal());

foreach (var product in productManager.GetByUnitPrice(50, 100).Data)
{
    Console.WriteLine(product.ProductName);
}
