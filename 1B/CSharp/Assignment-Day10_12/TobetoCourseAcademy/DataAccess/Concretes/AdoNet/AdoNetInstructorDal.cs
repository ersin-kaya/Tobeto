using Entities.Concretes;

namespace DataAccess.Concretes.AdoNet
{
    public class AdoNetInstructorDal
    {
        public void Add(Course instructor)
        {
            Console.WriteLine("Adonet kullanılarak eğitmen eklendi.");
        }
    }
}
