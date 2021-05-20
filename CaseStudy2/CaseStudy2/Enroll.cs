using System;

namespace CaseStudy2
{
    class Enroll
    {
        private Student student;
        private Course course;
        private DateTime enrollmentDate;


        public Enroll(Student student, Course course, DateTime enrolldate)
        {
            this.student = student;
            this.course = course;
            this.enrollmentDate = enrolldate;
        }

        public static int display(Enroll enroll)
        {
            if (enroll != null)
            {
                Console.WriteLine($"EnrolledStudent:{enroll.student.StudentName} ||EnrolledCourse:{enroll.course.CourseName}" +
                    $"|| EnrollmentDate:{enroll.enrollmentDate.ToString("MM/dd/yyyy")}");
                return 1;
            }
            return 0;
        }
    }
}
