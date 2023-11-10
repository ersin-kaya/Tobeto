using System;
using Entities.Concretes;

namespace DataAccess.Concretes
{
	public class AdoNetCategoryDal
	{
		public void Add(Category category)
		{
			Console.WriteLine("Ado.Net kullanılarak veri tabanına eklendi...: " + category.Name);
		}
	}
}

