using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ChallengeStudentCourses
{
    public class Enrollment
    {
        public int Grade { get; set; }
        public string Student { get; set; }
        public List<Course> Courses { get; set; }
    }
}