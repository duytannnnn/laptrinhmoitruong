using System;
using System.Collections.Generic;
using System.Text;

namespace QLSV.DAL
{
    public class Student
    {
        public int Id { get; set; }
        public string FullName { get; set; } = string.Empty;
        public double Grade { get; set; }
    }
}