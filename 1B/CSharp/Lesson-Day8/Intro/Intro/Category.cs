using System;
using System.Collections.Generic;

namespace Intro
{
    public class Category
    {
        //property'ler veri tabanındaki kolonlara karşılık gelir
        public int Id { get; set; }
        public string Name { get; set; }

        //ancak bunlar değil...
        public List<Course> Categories { get; set; }
    }
}

