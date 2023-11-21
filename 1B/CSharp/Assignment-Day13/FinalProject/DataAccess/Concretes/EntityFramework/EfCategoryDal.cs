using System.Linq.Expressions;
using Core.DataAccess.EntityFramework;
using DataAccess.Abstracts;
using Entities.Concretes;

namespace DataAccess.Concretes.EntityFramework
{
    public class EfCategoryDal : EfEntityRepositoryBase<Category, NorthwindContext>, ICategoryDal
    {
    }
}

