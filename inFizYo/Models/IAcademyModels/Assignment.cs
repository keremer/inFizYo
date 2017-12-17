using System;

namespace inFizYon.AcademyModels
{
    public class Assignment
    {
        public int AssignmentID { get; set; }
        public string AssignmentDef { get; set; }  
        public DateTime GivenDate { get; set; }
        public DateTime DueDate { get; set; }

        public Course CourseAssignment { get; set; }
    }
}
