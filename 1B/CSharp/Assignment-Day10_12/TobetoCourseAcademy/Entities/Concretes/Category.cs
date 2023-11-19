using System.ComponentModel.DataAnnotations.Schema;
using Core.Entities;

namespace Entities.Concretes
{
    public class Category : IEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        
        [NotMapped]
        public List<Course>? Courses { get; set; }
    }
}
