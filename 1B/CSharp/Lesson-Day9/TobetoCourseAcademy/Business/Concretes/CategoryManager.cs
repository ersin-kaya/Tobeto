using System;
using DataAccess.Concretes;
using Entities.Concretes;

namespace Business.Concretes
{
	public class CategoryManager
	{
		public void Add(Category category)
		{
            //business rules...
            AdoNetCategoryDal categoryDal = new AdoNetCategoryDal();
            categoryDal.Add(category);
        }
	}
}

