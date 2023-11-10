using System;
using DataAccess.Concretes;
using Entities.Concretes;

namespace Business.Concretes
{
	public class CourseManager
	{
		public void Add(Course course)
		{
			AdoNetCourseDal courseDal = new AdoNetCourseDal();
			courseDal.Add(course);
		}
	}
}

