using Business.Concretes;
using Entities.Concretes;

Product product1 = new Product() { Id = 1, Name = "Kalem", UnitPrice = 12.4 };

ProductManager productManager = new ProductManager();
productManager.Add(product1);