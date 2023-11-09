using System;

namespace Intro
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
        //public Instructor[] Instructors { get; set; }
        //many-to-many hiçbir zaman gerekli değildir, bu tip durumları ara tablolarla çözeriz
        public CourseInstructor[] CourseInstructors { get; set; }
    }
}