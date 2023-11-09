using Intro;

Category programming = new Category();
programming.Id = 1;
programming.Name = "Programlama";

Category database = new Category();
database.Id = 2;
database.Name = "Veri Tabanı";

//-------------------------

Course dotNet = new Course();
dotNet.Id = 1;
dotNet.CategoryId = 1;
dotNet.Name = ".NET";
dotNet.Description = "OOP";
dotNet.Price = 200;
dotNet.ImageUrl = "dotnet-icon.png";

Course oracle = new Course()
{
    Id = 2,
    CategoryId = 2,
    Name = "Oracle",
    Description = "GroupBy",
    Price = 500
};

//-------------------------

CourseInstructor courseInstructor1 = new CourseInstructor();
courseInstructor1.Id = 1;
courseInstructor1.InstructorId = 1;
courseInstructor1.CourseId = dotNet.Id;

CourseInstructor courseInstructor2 = new CourseInstructor();
courseInstructor2.Id = 2;
courseInstructor2.InstructorId = 2;
courseInstructor2.CourseId = oracle.Id;

CourseInstructor courseInstructor3 = new CourseInstructor();
courseInstructor3.Id = 3;
courseInstructor3.InstructorId = 1;
courseInstructor3.CourseId = oracle.Id;

//-------------------------

Instructor instructor1 = new Instructor();
instructor1.Name = "Engin Demiroğ";
instructor1.Id = 1;
instructor1.CourseInstructors = new List<CourseInstructor> { courseInstructor1, courseInstructor3 };

Instructor instructor2 = new Instructor();
instructor2.Name = "İrem Balcı";
instructor2.Id = 2;
instructor2.CourseInstructors = new List<CourseInstructor> { courseInstructor2 };