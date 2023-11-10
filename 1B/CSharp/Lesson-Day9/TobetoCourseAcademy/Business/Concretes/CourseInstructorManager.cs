using System;
using DataAccess.Concretes;
using Entities.Concretes;

namespace Business.Concretes
{
	public class CourseInstructorManager
	{
		public void Add(CourseInstructor courseInstructor)
		{
			AdoNetCourseInstructorDal courseInstructorDal = new AdoNetCourseInstructorDal();
			courseInstructorDal.Add(courseInstructor);
        }
	}
}

