using Business.Abstracts;
using Business.Constants;
using Core.Utilities.Results.Abstracts;
using Core.Utilities.Results.Concretes;
using DataAccess.Abstracts;
using Entities.Concretes;
using Entities.DTOs;

namespace Business.Concretes
{
    public class CourseManager : ICourseService
    {
        ICourseDal _courseDal;

        public CourseManager(ICourseDal courseDal)
        {
            _courseDal = courseDal;
        }

        public IResult Add(Course course)
        {
            if (course.UnitPrice >= 100) 
            {                  
                _courseDal.Add(course);
                return new SuccessResult(Messages.Added);
            }
            return new ErrorResult(Messages.NotAdded);
        }

        public IResult Delete(Course course)
        {
            _courseDal.Delete(course);
            return new SuccessResult(Messages.Deleted);
        }

        public IDataResult<List<Course>> GetAll()
        {
            var data = _courseDal.GetAll();
            if (data.Count > 5)
            {
                return new SuccessDataResult<List<Course>>(data, Messages.CoursesListed);
            }
            return new ErrorDataResult<List<Course>>(Messages.CoursesNotListed);
        }

        public IDataResult<CourseDetailDTO> GetCourseDetails(int id)
        {
            var result = _courseDal.GetCourseDetails(id);
            return new SuccessDataResult<CourseDetailDTO>(result, Messages.CourseDetailsListed);
        }

        public IResult Update(Course course)
        {
            _courseDal.Update(course);
            return new SuccessResult(Messages.Updated);
        }
    }
}
