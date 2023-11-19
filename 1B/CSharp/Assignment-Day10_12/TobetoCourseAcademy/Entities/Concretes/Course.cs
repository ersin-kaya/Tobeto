using System.ComponentModel.DataAnnotations.Schema;
using Core.Entities;

namespace Entities.Concretes
{
    public class Course : IEntity
    {
        public int Id { get; set; }
        public int CategoryId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public double UnitPrice { get; set; }
        public string? ImageUrl { get; set; }

        [NotMapped]
        public Category? Category { get; set; }
        [NotMapped]
        public List<CourseInstructor>? CourseInstructors { get; set; }
    }
}
