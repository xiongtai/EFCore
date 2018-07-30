using System;
using System.Collections.Generic;
using System.Text;

namespace LinqPad.SchoolModel
{
    public class Course
    {
        public Course()
        {
            Sections = new List<Section>();
        }
        public int CourseId { get; set; }
        public string Title { get; set; }
        public virtual ICollection<Section> Sections { get; set; }
    }
}
