using System.ComponentModel.DataAnnotations.Schema;
using Core.Entities;

namespace Entities.Concretes
{
    public class CourseInstructor : IEntity
    {
        public int Id { get; set; }
        public int CourseId { get; set; }
        public int InstructorId { get; set; }

        [NotMapped]
        public Course? Course { get; set; }
        [NotMapped]
        public Instructor? Instructor { get; set; }
    }
}
