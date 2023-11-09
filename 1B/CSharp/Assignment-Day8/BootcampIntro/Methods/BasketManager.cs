using System;
namespace Methods
{
	public class BasketManager
	{
		public void Add(Product product)
		{
			Console.WriteLine("Tebrikler. {0} Sepete eklendi!", product.Name);
		}

		public void Add2(string productName, double price, string description, double stock)
		{
			Console.WriteLine("Tebrikler. {0} Sepete eklendi!", productName);
		}
	}
}

