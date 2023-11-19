using Core.DataAccess;
using Entities.Concretes;
using Entities.DTOs;

namespace DataAccess.Abstracts
{
    public interface ICourseDal : IEntityRepository<Course>
    {
        public CourseDetailDTO GetCourseDetails(int id);
    }
}
