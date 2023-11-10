using System;
using DataAccess.Concretes;
using Entities.Concretes;

namespace Business.Concretes
{
	public class InstructorManager
	{
        public void Add(Instructor instructor)
        {
            //business rules...
            AdoNetInstructorDal instructorDal = new AdoNetInstructorDal();
            instructorDal.Add(instructor);
        }
    }
}

