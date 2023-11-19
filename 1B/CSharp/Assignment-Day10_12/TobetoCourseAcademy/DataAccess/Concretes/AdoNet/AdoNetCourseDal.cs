using Entities.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concretes.AdoNet
{
    public class AdoNetCourseDal
    {
        public void Add(Course Course)
        {
            Console.WriteLine("Adonet kullanılarak kurs eklendi.");
        }
    }
}
