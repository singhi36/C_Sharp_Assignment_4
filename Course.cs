﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Assignment_4
{
 
    internal class Course
    {
        public int CourseID { get; set; }

        public string Code { get; set; }

        public string Name { get; set; }

        public List<Student> students = new List<Student>();

    }
}
