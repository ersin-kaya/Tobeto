using Core.Utilities.Results.Abstracts;
using Entities.Concretes;
using Entities.DTOs;

namespace Business.Abstracts
{
    public interface ICourseService
    {
        IDataResult<List<Course>> GetAll();
        IResult Add(Course course);
        IResult Delete(Course course);
        IResult Update(Course course);
        IDataResult<CourseDetailDTO> GetCourseDetails(int id);
    }
}
