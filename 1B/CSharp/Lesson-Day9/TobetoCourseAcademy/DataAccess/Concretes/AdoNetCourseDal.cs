using System;
using Entities.Concretes;

namespace DataAccess.Concretes
{
    public class AdoNetCourseDal
    {
        public void Add(Course course)
        {
            Console.WriteLine("Ado.Net kullanılarak veri tabanına eklendi...: " + course.Name);
        }
    }
}

