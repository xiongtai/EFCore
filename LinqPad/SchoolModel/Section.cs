using System;
using System.Collections.Generic;
using System.Text;

namespace LinqPad.SchoolModel
{
    public class Section
    {
        public Section()
        {
            SectionStudents = new List<SectionStudent>();
        }
        public int SectionId { get; set; }
        public int InstructorId { get; set; }
        public int CourseId { get; set; }
        public virtual Course Course { get; set; }       
        public virtual Instructor Instructor { get; set; }        
        public virtual ICollection<SectionStudent> SectionStudents { get; set; }
    }
}
