using System;
namespace Entities.Concretes
{
	public class Course
	{
		public int Id { get; set; }
		public int CategoryId { get; set; }
		public string Name { get; set; }
		public string Description { get; set; }
		public double Price { get; set; }
		public string ImageUrl { get; set; }

		public Category Category { get; set; }
		public List<CourseInstructor> CourseInstructors { get; set; }
	}
}

