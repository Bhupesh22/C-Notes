using System;

namespace CaseStudy2
{
    class Student
    {
        public int StudentID { get; set; }
        public string StudentName { get; set; }
        public string StudentDOB { get; set; }

        public Student(int id, string name, string dob)
        {
            StudentID = id;
            StudentName = name;
            StudentDOB = dob;
        }
    }
    class Course
    {
        public int CourseId { get; set; }
        public string CourseName { get; set; }
        public int CourseDuration { get; set; }
        public decimal CourseFees { get; set; }

        public Course(int id, string name, int duration, decimal fees)
        {
            CourseId = id;
            CourseName = name;
            CourseDuration = duration;
            CourseFees = fees;
        }
    }
    class Info
    {
        public int display(Student student)
        {
            if (student != null)
            {
                Console.WriteLine($"StudentId:{student.StudentID} || StudentName:{student.StudentName} " +
                $"|| StudentDOB:{student.StudentDOB}");
                return 1;
            }
            return 0;

        }

        public int display(Course course)
        {
            if (course != null)
            {
                Console.WriteLine($"CourseId:{course.CourseId} || CourseName:{course.CourseName}" +
                $"|| CourseDuration:{course.CourseDuration} || CourseFees:{course.CourseFees}");
                return 1;
            }
            return 0;
        }

    }
    class Search
    {
        public Student searchdata(Student[] s, int id)
        {
            foreach (Student stu in s)
            {
                if (stu.StudentID == id)
                {
                    return stu;
                }
            }
            return null;
        }

        public Course searchdata(Course[] c, int id)
        {
            foreach (Course cou in c)
            {
                if (cou.CourseId == id)
                {
                    return cou;
                }
            }
            return null;
        }
    }
    class App
    {
        static void Main()
        {
            int choice = 0;
            AppEngine appEngine = new AppEngine();
            Info info = new Info();
            do
            {
                Console.WriteLine("--------------Welcome to Student Dashboard!--------------");
                Console.WriteLine("Choose one of the following:\n1)Register new student \n2)Courses Introduction" +
                    "\n3)List of Students \n4)List of Courses \n5)Enroll \n6)List of enrollments \n7)Exit");
                choice = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("-------------------------------------------");
                switch (choice)
                {
                    case 1:
                        Console.WriteLine("New Students Please Register Here!");
                        Console.WriteLine("Enter Student id:");
                        int id = Convert.ToInt32(Console.ReadLine());

                        Console.WriteLine("Enter Student name:");
                        string name = Console.ReadLine();


                        Console.WriteLine("Enter Student dob:");
                        string dob = Console.ReadLine();
                        Student s = new Student(id, name, dob);
                        appEngine.Register(s);
                        Console.WriteLine("-------------------------------------------");
                        break;

                    case 2:
                        Console.WriteLine("Enter Course id:");
                        int cid = Convert.ToInt32(Console.ReadLine());

                        Console.WriteLine("Enter Course name:");
                        string cname = Console.ReadLine();

                        Console.WriteLine("Enter Course Duration in Years:");
                        int cduration = Convert.ToInt32(Console.ReadLine());

                        Console.WriteLine("Enter Course Fees:");
                        decimal cfees = Convert.ToDecimal(Console.ReadLine());
                        Course c = new Course(cid, cname, cduration, cfees);

                        appEngine.Introduce(c);
                        Console.WriteLine("-------------------------------------------");
                        break;

                    case 3:
                        Student[] studlist = appEngine.ListOfStudents();
                        if (studlist == null)
                        {
                            Console.WriteLine("No students added!");
                        }
                        else
                        {
                            foreach (Student stu in studlist)
                            {
                                if (info.display(stu) == 1)
                                {
                                    continue;
                                }
                                else
                                {
                                    break;
                                }

                            }
                        }

                        Console.WriteLine("-------------------------------------------");
                        break;

                    case 4:
                        Course[] courselist = appEngine.ListOfCourses();
                        if (courselist == null)
                        {
                            Console.WriteLine("No course added!");
                        }
                        else
                        {
                            foreach (Course cou in courselist)
                            {
                                if (info.display(cou) == 1)
                                {
                                    continue;
                                }
                                else
                                {
                                    break;
                                }
                            }
                        }

                        Console.WriteLine("-------------------------------------------");
                        break;

                    case 5:
                        Console.WriteLine("Enter Student id:");
                        int esid = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Enter Course id:");
                        int ecid = Convert.ToInt32(Console.ReadLine());
                        //search for the record
                        Search search = new Search();
                        Student ss = search.searchdata(appEngine.ListOfStudents(), esid);
                        Course cs = search.searchdata(appEngine.ListOfCourses(), ecid);

                        //enroll
                        if (ss != null && cs != null)
                        {
                            appEngine.EnrollStudent(ss, cs);
                        }
                        else
                        {
                            Console.WriteLine("Cannot enroll");
                        }
                        Console.WriteLine("-------------------------------------------");
                        break;

                    case 6:
                        Enroll[] enrolls = appEngine.ListOfEnrollments();
                        if (enrolls != null)
                        {
                            foreach (Enroll e in enrolls)
                            {
                                if (Enroll.display(e) == 1)
                                {
                                    continue;
                                }
                                else
                                {
                                    break;
                                }
                            }
                        }
                        else
                        {
                            Console.WriteLine("No enrollments yet");
                        }
                        Console.WriteLine("-------------------------------------------");
                        break;
                    case 7:
                        Environment.Exit(1);
                        break;
                    default:
                        Console.WriteLine("Enter valid choice:");
                        break;
                }
            } while (choice != 7);

            Console.WriteLine("Thankyou!");
            Console.Read();
        }
    }
}
