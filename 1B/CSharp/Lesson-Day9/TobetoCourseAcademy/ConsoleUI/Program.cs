using Business.Concretes;
using Entities.Concretes;

//Categories
Console.WriteLine();
Console.WriteLine("----- Categories -----");

Category category1 = new Category { Id = 1, Name = "Programlama" };
Category category2 = new Category { Id = 2, Name = "Veri Tabanı" };

CategoryManager categoryManager = new CategoryManager();
categoryManager.Add(category1);
categoryManager.Add(category2);


//Instructors
Console.WriteLine();
Console.WriteLine("----- Instructors -----");

Instructor instructor1 = new Instructor { Id = 1, Name = "Engin Demiroğ" };
Instructor instructor2 = new Instructor { Id = 2, Name = "İrem Balcı" };

InstructorManager instructorManager = new InstructorManager();
instructorManager.Add(instructor1);
instructorManager.Add(instructor2);


//Courses
Console.WriteLine();
Console.WriteLine("----- Courses -----");

Course course1 = new Course()
{
    Id = 1,
    CategoryId = 1,
    Name = ".NET Bootcamp",
    Price = 5000,
    Description = "#",
    ImageUrl = "#"
};

Course course2 = new Course()
{
    Id = 2,
    CategoryId = 2,
    Name = "Oracle",
    Price = 5500,
    Description = "#",
    ImageUrl = "#"
};

CourseManager courseManager = new CourseManager();
courseManager.Add(course1);
courseManager.Add(course2);


//Course Instructors
Console.WriteLine();
Console.WriteLine("----- Course Instructors -----");

CourseInstructor courseInstructor1 = new CourseInstructor()
{
    Id = 1,
    CourseId = 1,
    InstructorId = 1
};

CourseInstructor courseInstructor2 = new CourseInstructor()
{
    Id = 2,
    CourseId = 2,
    InstructorId = 2
};

CourseInstructor courseInstructor3 = new CourseInstructor()
{
    Id = 3,
    CourseId = 2,
    InstructorId = 1
};

CourseInstructorManager courseInstructorManager = new CourseInstructorManager();
courseInstructorManager.Add(courseInstructor1);
courseInstructorManager.Add(courseInstructor2);
courseInstructorManager.Add(courseInstructor3);