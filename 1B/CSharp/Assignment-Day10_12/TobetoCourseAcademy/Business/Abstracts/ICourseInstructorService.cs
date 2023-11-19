using Core.Utilities.Results.Abstracts;
using Entities.Concretes;

namespace Business.Abstracts
{
    public interface ICourseInstructorService
    {
        IDataResult<List<CourseInstructor>> GetAll();
        IResult Add(CourseInstructor courseInstructor);
        IResult Delete(CourseInstructor courseInstructor);
        IResult Update(CourseInstructor courseInstructor);
    }
}
