using System;
namespace Intro
{
    public class CourseInstructor
    {
        public int Id { get; set; }
        public int CourseId { get; set; }
        public int InstructorId { get; set; }

        //yukarıdaki foreign key'lerin karşılığını buraya da yazıyoruz
        //ki her seferinde gidip Id'den çekmek zorunda kalmayalım, doğrudan elimizin altında olsun
        public Course Course { get; set; }
        public Instructor Instructor { get; set; }
    }
}

