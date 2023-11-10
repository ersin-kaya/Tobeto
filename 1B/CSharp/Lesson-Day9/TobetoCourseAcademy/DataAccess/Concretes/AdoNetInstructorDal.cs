using System;
using Entities.Concretes;

namespace DataAccess.Concretes
{
	public class AdoNetInstructorDal
	{
		public void Add(Instructor instructor)
		{
            Console.WriteLine("Ado.Net kullanılarak veri tabanına eklendi...: " + instructor.Name);
        }
	}
}

