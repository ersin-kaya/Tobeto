using Core.DataAccess.EntityFramework;
using DataAccess.Abstracts;

using Entities.Concretes;
using Entities.DTOs;

namespace DataAccess.Concretes.EntityFramework
{
    public class EfCourseDal : EfEntityRepositoryBase<Course, TobetoCourseAcademyContext>, ICourseDal
    {
        public CourseDetailDTO GetCourseDetails(int id)
        {
            using (TobetoCourseAcademyContext context = new TobetoCourseAcademyContext())
            {
                var result = from co in context.Courses
                             join ca in context.Categories
                             on co.CategoryId equals ca.Id
                             where co.Id == id
                             select new CourseDetailDTO
                             {
                                 CategoryName = ca.Name,
                                 CourseName = co.Name,
                                 UnitPrice = co.UnitPrice
                             };
            
                return result.FirstOrDefault();
            }
        }
    }
}
