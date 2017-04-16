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

            string result = "";
            
            List<Course> courses = new List<Course>()
            {
                new Course { Name = "Psychology", CourseId = 111,
                    Students = new List<Student>() { new Student() {Name = "Joey Casto", StudentId = 1},
                                                     new Student() {Name= "Ryan Casto", StudentId = 2}}},
                new Course { Name = "Computer Science", CourseId = 222,
                    Students = new List<Student>() { new Student() {Name = "Becca Casto", StudentId = 3},
                                                     new Student() {Name = "Sophia Casto", StudentId = 4}}},
                new Course { Name = "Physics", CourseId = 333,
                    Students = new List<Student>() { new Student() {Name = "James Tabbert", StudentId = 5},
                                                     new Student() {Name = "Vladika Tabbert", StudentId = 6}}}
            };

            foreach (var course in courses)
            {
               resultLabel.Text += String.Format("<b>Course: {0}</b></br> Course ID: {1}</br>", course.Name, course.CourseId);
                foreach (var student in course.Students)
                {
                    resultLabel.Text += String.Format("&nbsp;&nbsp Student: {0}</br>&nbsp;&nbsp Student ID: {1}</br>", student.Name, student.StudentId);
                }          
            };          
        }            

        protected void assignmentTwoButton_Click(object sender, EventArgs e)
        {
            Dictionary<string, Student> students = new Dictionary<string, Student>()
           {
               {"A1", new Student {Name = "Joey Casto", StudentId = 1}},
               {"A2", new Student {Name = "Ryan Casto", StudentId = 2}},
               {"A3", new Student {Name = "Sophia Casto", StudentId = 3}}
           };
            
        }

        protected void assignmentThreeButton_Click(object sender, EventArgs e)
        {
            
        }
    }
}