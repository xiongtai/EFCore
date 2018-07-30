using System;
using System.Collections.Generic;
using System.Text;

namespace LinqPad.SchoolModel
{
    public class Student
    {
        public Student()
        {
            SectionStudent = new List<SectionStudent>();
        }

        public int StudentId { get; set; }
        public string Name { get; set; }        
        public virtual ICollection<SectionStudent> SectionStudent { get; set; }
    }
}
