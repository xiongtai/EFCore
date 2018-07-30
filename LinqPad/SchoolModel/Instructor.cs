using System;
using System.Collections.Generic;
using System.Text;

namespace LinqPad.SchoolModel
{
    public class Instructor
    {
        public Instructor()
        {
            Sections = new List<Section>();
        }
        public int InstructorId { get; set; }
        public string Name { get; set; }
        public virtual ICollection<Section> Sections { get; set; }
    }
}
