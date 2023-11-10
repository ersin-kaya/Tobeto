using System;
namespace Entities.Concretes
{
	public class Instructor
	{
		public int Id { get; set; }
		public string Name { get; set; }

		public List<CourseInstructor> CourseInstructors { get; set; }
	}
}

