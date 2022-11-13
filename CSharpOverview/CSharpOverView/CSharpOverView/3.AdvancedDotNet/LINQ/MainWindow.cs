//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace CSharpOverView._3.AdvancedDotNet.LINQ
//{
//    internal class MainWindow
//    {
//        private List<Student> students;
//        private List<Course> courses;
//        private List<Department> departments;

//        public MainWindow()
//        {

//            students = new List<Student>()
//            {
//                new Student() { ID = 1, FirstName = "Mieke", LastName = "Smet", Age = 33, CourseID = 1 },
//                new Student() { ID = 1, FirstName = "Ann", LastName = "Boonen", Age = 25, CourseID = 1 },
//                new Student() { ID = 1, FirstName = "Wim", LastName = "Claeys", Age = 37, CourseID = 2 },
//                new Student() { ID = 1, FirstName = "Rudy", LastName = "Foster", Age = 43, CourseID = 2 },
//                new Student() { ID = 1, FirstName = "Tim", LastName = "Mertens", Age = 35, CourseID = 3 },
//                new Student() { ID = 1, FirstName = "Anthony", LastName = "Gevaert", Age = 19, CourseID = 1 },
//            };

//            courses = new List<Course>()
//            {
//                new Course() { ID = 1, Duration = 100, Name = "C#", DepartmentID = 1},
//                new Course() { ID = 2, Duration = 60, Name = "C++", DepartmentID = 1},
//                new Course() { ID = 3, Duration = 40, Name = "Electricien", DepartmentID = 2},
//            };

//            departments = new List<Department>()
//            {
//                new Department() { ID = 1, Address = "Straat 123, 8000 Brugge", Name = "Syntra West - Brugge"},
//                new Department() { ID = 2, Address = "Straat 123, 8500 Kortrijk", Name = "Syntra West - Kortrijk"},
//            };

//            UnfilteredList.DisplayMemberPath = "FirstName";
//            UnfilteredList.ItemsSource = students;
//        }

//        private void Button1_Click(object sender, RoutedEventArgs e)
//        {
//            FilteredList.ItemsSource = from student in students
//                                       join course in courses on student.CourseID equals course.ID
//                                       select student.FirstName + " " + student.LastName + " " + course.Name;
//        }

//        private void Button2_Click(object sender, RoutedEventArgs e)
//        {
//            FilteredList.ItemsSource = students.Join(courses, student => student.CourseID, course => course.ID, (student, course) => new { student, course })
//                                               .Select(grouping => grouping.student.FirstName + " " + grouping.student.LastName + " " + grouping.course.Name);
//        }

//        private void Button3_Click(object sender, RoutedEventArgs e)
//        {
//            FilteredList.ItemsSource = from student in students
//                                       join course in courses on student.CourseID equals course.ID
//                                       join department in departments on course.DepartmentID equals department.ID
//                                       select student.FirstName + " " + student.LastName + " " + course.Name + " " + department.Name;
//        }

//        private void Button4_Click(object sender, RoutedEventArgs e)
//        {
//            FilteredList.ItemsSource = students.Join(courses, student => student.CourseID, course => course.ID, (student, course) => new { student, course })
//                                               .Join(departments, grouping => grouping.course.DepartmentID, department => department.ID, (grouping, department) => new { student = grouping.student, course = grouping.course, department })
//                                               .Select(grouping => grouping.student.FirstName + " " + grouping.student.LastName + " " + grouping.course.Name + " " + grouping.department.Name);
//        }
//    }
//}
