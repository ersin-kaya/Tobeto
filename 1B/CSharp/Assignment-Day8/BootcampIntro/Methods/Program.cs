//Don't repeat yourself - DRY - Clean Code - Best Practice
using Methods;

Product product1 = new Product();
product1.Name = "Elma";
product1.Price = 15;
product1.Description = "Amasya elması";

Product product2 = new Product();
product2.Name = "Karpuz";
product2.Price = 80;
product2.Description = "Diyarbakır karpuzu";

Product[] products = new Product[] { product1, product2 };

//type-safe
//foreach (Product product in products)
//{
//    Console.WriteLine(product.Name);
//    Console.WriteLine(product.Price);
//    Console.WriteLine(product.Description);
//    Console.WriteLine("----");
//}

Console.WriteLine("------------Methods------------");

//encapsulation
BasketManager basketManager = new BasketManager();
basketManager.Add(product1);
basketManager.Add(product2);

basketManager.Add2("Armut", 12, "Yeşil armut", 10);
basketManager.Add2("Elma", 12, "Yeşil elma", 9);
basketManager.Add2("Karpuz", 12, "Diyarbakır karpuzu", 4);