using System.ComponentModel.DataAnnotations.Schema;
using Core.Entities;

namespace Entities.Concretes
{
    public class Instructor : IEntity
    {
        public int Id { get; set; }
        public string FirstName { get; set; }   
        public string LastName { get; set; }
        public string Description { get; set; }

        [NotMapped]
        public List<CourseInstructor>? CourseInstructors { get; set; }
    }
}
