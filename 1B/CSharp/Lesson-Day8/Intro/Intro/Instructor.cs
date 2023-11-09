using System;
using System.Collections.Generic;

namespace Intro
{
    public class Instructor
    {
        public int Id { get; set; }
        public string Name { get; set; }

        //bu kısım onlara rahat ulaşmak için yazılan ilişkiler, veri tabanı tablomuza yazmıyoruz
        public List<CourseInstructor> CourseInstructors { get; set; }
    }
}

