using System;
using Entities.Concretes;

namespace DataAccess.Concretes
{
	public class AdoNetCourseInstructorDal
	{
        public void Add(CourseInstructor courseInstructor)
        {
            Console.WriteLine("Ado.Net kullanılarak veri tabanına eklendi...: courseId: {0} - instructorId: {1}", courseInstructor.CourseId, courseInstructor.InstructorId);
        }
    }
}

