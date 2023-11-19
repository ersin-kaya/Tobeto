using Business.Concretes;
using DataAccess.Concretes.EntityFramework;
using Entities.Concretes;

Instructor instructor1 = new Instructor()
{
    FirstName = "Engin",
    LastName = "Demiroğ",
    Description = "--"    
};

Instructor instructor2 = new Instructor()
{
    FirstName = "Halit Enes",
    LastName = "Kalaycı",
    Description = "--"
};

Instructor instructor3 = new Instructor()
{
    FirstName = "İrem",
    LastName = "Balcı",
    Description = "--"
};

Instructor instructor4 = new Instructor()
{
    FirstName = "Ahmet",
    LastName = "Çetinkaya",
    Description = "--"
};

InstructorManager instructorManager = new InstructorManager(new EfInstructorDal());
//instructorManager.Add(instructor1);
//instructorManager.Add(instructor2);
//instructorManager.Add(instructor3);
//instructorManager.Add(instructor4);

Category category1 = new Category()
{
    Name = "Programlama",
    Description = "Programlama kurslarımız bu kategoridedir"
};

Category category2 = new Category()
{
    Name = "Veritabanı",
    Description = "Veritabanı kurslarımız bu kategoridedir"
};

CategoryManager categoryManager = new CategoryManager(new EfCategoryDal());
//categoryManager.Add(category1);
//categoryManager.Add(category2);

Course course1 = new Course()
{
    CategoryId = 1,
    Name = "CSharp",
    Description = "",
    UnitPrice = 300,
};

Course course2 = new Course()
{
    CategoryId = 1,
    Name = "Java",
    Description = "",
    UnitPrice = 200,
};

Course course3 = new Course()
{
    CategoryId = 1,
    Name = "JavaScript",
    Description = "",
    UnitPrice = 200,
};

Course course4 = new Course()
{
    CategoryId = 1,
    Name = "C++",
    Description = "",
    UnitPrice = 250,
};

Course course5 = new Course()
{
    CategoryId = 2,
    Name = "Oracle",
    Description = "",
    UnitPrice = 500,
};

Course course6 = new Course()
{
    CategoryId = 2,
    Name = "MSSQL",
    Description = "",
    UnitPrice = 600,
};

CourseManager courseManager = new CourseManager(new EfCourseDal());
//courseManager.Add(course1);
//courseManager.Add(course2);
//courseManager.Add(course3);
//courseManager.Add(course4);
//courseManager.Add(course5);
//courseManager.Add(course6);

CourseInstructor courseInstructorCSharp1 = new CourseInstructor 
{ 
    CourseId = 1,
    InstructorId = 1,
};

CourseInstructor courseInstructorCSharp2 = new CourseInstructor
{
    CourseId = 1,
    InstructorId = 2,
};

CourseInstructor courseInstructorJava1 = new CourseInstructor
{
    CourseId = 2,
    InstructorId = 2,
};

CourseInstructor courseInstructorJava2 = new CourseInstructor
{
    CourseId = 2,
    InstructorId = 4,
};

CourseInstructor courseInstructorMSSQL1 = new CourseInstructor
{
    CourseId = 6,
    InstructorId = 3,
};

CourseInstructorManager courseInstructorManager = new CourseInstructorManager(new EfCourseInstructorDal());
//courseInstructorManager.Add(courseInstructorCSharp1);
//courseInstructorManager.Add(courseInstructorCSharp2);
//courseInstructorManager.Add(courseInstructorJava1);
//courseInstructorManager.Add(courseInstructorJava2);
//courseInstructorManager.Add(courseInstructorMSSQL1);


//var courses = courseManager.GetAll();
//foreach (var course in courses)
//{
//var courseDetail = courseManager.GetCourseDetails(course);
//    Console.WriteLine("kurs adı: {0} / kategori adı: {1}", courseDetail.CourseName, courseDetail.CategoryName);
//    Console.WriteLine();
//}

//var courseDetail1 = courseManager.GetCourseDetails(courses.Where(c => c.Id == 1).FirstOrDefault());
//Console.WriteLine("kurs adı: {0} / kategori adı: {1}", courseDetail1.CourseName, courseDetail1.CategoryName);

var result = courseManager.GetAll();


if (result.Success)
{
    foreach (var course in result.Data)
    {
        Console.WriteLine(course.Name);
    }
    Console.WriteLine(result.Message);
}
else
{
    Console.WriteLine(result.Message);
}
