using System;
using System.Collections.Generic;


namespace CaseStudy3
{
    class AppEngine
    {
        List<Student> studentList = new List<Student>();
        List<Course> courseList = new List<Course>();
        List<Enroll> enrollList = new List<Enroll>();

        public void Introduce(Course course)
        {
            courseList.Add(course);
        }

        public void Register(Student student)
        {
            studentList.Add(student);
        }

        public List<Student> ListOfStudents()
        {
            if(studentList.Count == 0)
            {
                return null;
            }
            return studentList;
        }

        public List<Course> ListOfCourses()
        {
            if(courseList.Count == 0)
            {
                return null;
            }
            return courseList;
        }

        public List<Enroll> ListOfEnrollments()
        {
            if(enrollList.Count == 0)
            {
                return null;
            }
            return enrollList;
        }

        public void EnrollStudent(Student student, Course course)
        {
            enrollList.Add(new Enroll(student, course, DateTime.Now));
            Console.WriteLine("Enrolled Successfully");
        }
    }
}
