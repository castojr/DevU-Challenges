using System.Collections.Generic;

namespace ChallengeStudentCourses
{
    public class Grade
    {
        public int Percentage { get; set; }
        public string Letter { get; set; }
        public List<Course> Courses {get; set; }
        public List<Student> Students { get; set; }
    }
}