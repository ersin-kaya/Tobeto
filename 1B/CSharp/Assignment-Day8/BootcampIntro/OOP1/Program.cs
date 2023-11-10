using OOP1;

Product product1 = new Product()
{
    Id = 1,
    CategoryId = 2,
    ProductName = "Masa",
    UnitPrice = 500,
    UnitsInStock = 3
};

Product product2 = new Product
{
    Id = 2,
    CategoryId = 5,
    UnitsInStock = 5,
    ProductName = "Kalem",
    UnitPrice = 35
};

ProductManager productManager = new ProductManager();
productManager.Add(product1);
Console.WriteLine(product1.ProductName);