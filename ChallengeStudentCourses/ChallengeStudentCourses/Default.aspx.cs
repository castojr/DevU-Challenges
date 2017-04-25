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
            Course course1 = new Course() {Name = "Psychology", CourseId = 111};
            Course course2 = new Course() {Name = "Computer Science", CourseId = 101};
            Course course3 = new Course() {Name = "Philosophy", CourseId = 201};
            Course course4 = new Course() {Name = "Art", CourseId = 202};


            Dictionary<int, Student> students = new Dictionary<int, Student>()
           {
               {1, new Student {Name = "Joey Casto", StudentId = 1, Courses = new List<Course> {course1, course2}}},
               {2, new Student {Name = "Ryan Casto", StudentId = 2, Courses = new List<Course> {course2, course3}}},
               {3, new Student {Name = "Sophia Casto", StudentId = 3, Courses = new List<Course> {course3, course4}}}
           };

            foreach (var student in students)
            {
                resultLabel.Text += String.Format("Student: {0}</br>" ,student.Value.Name) + "&nbsp Enrolled Courses</br>";
                foreach (var course in student.Value.Courses)
                {
                    resultLabel.Text += String.Format("&nbsp;&nbsp;&nbsp{0}</br>", course.Name);
                }
            };       
        }

        protected void assignmentThreeButton_Click(object sender, EventArgs e)
        {
            Course course1 = new Course() { Name = "Computer Science", CourseId = 1};
            Course course2 = new Course() { Name = "Engineering", CourseId = 2};
            Course course3 = new Course() { Name = "Chemistry", CourseId = 3};

            Dictionary<int, Student> students = new Dictionary<int, Student>()
            {
                {1, new Student {Name = "Joey Casto", StudentId = 1, Courses = new List<Course> {course1, course2 }}},
                {2, new Student {Name = "Ryan Casto", StudentId = 2, Courses = new List<Course> {course2, course3 }}}
            };

            foreach (var student in students)
            {
                resultLabel.Text += String.Format("Student: {0}</br>", student.Value.Name) + "&nbsp; Course: </br>";
                foreach (var course in student.Value.Courses)
                {
                    resultLabel.Text += String.Format("&nbsp;&nbsp;&nbsp;{0} </br>", course.Name);
                    /*foreach (var grade in student.Value.Grade)
                    {
                        resultLabel.Text += String.Format(" Grade {0}: {1}%</br>&nbsp;", grade.Letter, grade.Percentage);
                    }*/
                } 
            }
                
          }
                   
        }
    }
