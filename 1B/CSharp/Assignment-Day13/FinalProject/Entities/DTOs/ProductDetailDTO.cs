using System;
namespace Entities.DTOs
{
	public class ProductDetailDTO
	{
		public int ProductId { get; set; }
		public string ProductName { get; set; }
		public string CategoryName { get; set; }
		public int UnitsInStock { get; set; }
	}
}

