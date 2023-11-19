using Entities.Concretes;

namespace DataAccess.Concretes.AdoNet
{
    public class AdoNetCategoryDal
    {
        public void Add(Category category)
        {
            Console.WriteLine(category.Name + " Adonet kullanılarak categori eklendi.");
        }
    }
}
