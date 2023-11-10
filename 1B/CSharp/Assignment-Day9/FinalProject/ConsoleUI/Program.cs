using Business.Concretes;
using DataAccess.Concretes.InMemory;

ProductManager productManager = new ProductManager(new InMemoryProductDal());

foreach (var product in productManager.GetAll())
{
    Console.WriteLine(product.ProductName);
}
