using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.DTOs
{
    public class CourseDetailDTO: IDTO
    {
        public string CourseName { get; set; }
        public string CategoryName { get; set;}
        public double UnitPrice { get; set; }
    }
}
