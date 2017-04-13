using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ChallengeStudentCourses
{
    public partial class Default :System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void assignmentOneButton_Click(object sender, EventArgs e)
        {

            List<Course> courses = new List<Course>()
            {
                new Course() { Name = "Psychology", CourseId = 111,
                    Students = new List<Student>() { new Student() {Name = "Joey Casto", StudentId = 1},
                                                     new Student() {Name= "Ryan Casto", StudentId = 2}}},
                new Course() { Name = "Computer Science", CourseId = 222,
                    Students = new List<Student>() { new Student() {Name = "Becca Casto", StudentId = 3},
                                                     new Student() {Name = "Sophia Casto", StudentId = 4}}},
                new Course() { Name = "Physics", CourseId = 333,
                    Students = new List<Student>() { new Student() {Name = "James Tabbert", StudentId = 5},
                                                     new Student() {Name = "Vladika Tabbert", StudentId = 6}}}
            };
        }

            


        protected void assignmentTwoButton_Click(object sender, EventArgs e)
        {
           
        }

        protected void assignmentThreeButton_Click(object sender, EventArgs e)
        {
            
        }
    }
}