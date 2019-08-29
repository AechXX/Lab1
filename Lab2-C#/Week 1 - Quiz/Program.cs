using System;
using System.Collections.Generic;

namespace ConsoleAppLists
{
    class Program
    {
        static void Main(string[] args)
        {

            IDictionary<int, string> dictCourses = new Dictionary<int, string>();

            dictCourses.Add(101, "C#");
            dictCourses.Add(102, "HTML5");
            dictCourses.Add(103, "Database");

            foreach (KeyValuePair<int,string> item in dictCourses)
            {
                Console.WriteLine("Key: {0} || Value: {1}", item.Key, item.Value);
            }

            Console.ReadLine();





            
            // List using custom type (class)
            List<Students> myStudents = new List<Students>();

            Students objStudent = new Students();

            objStudent.FirstName = "John";
            objStudent.LastName = "Doe";
            objStudent.Enrolled = "Yes";



            myStudents.Add(objStudent);
            









            List<string> Courses = new List<string>();

            Courses.Add("C#");
            Courses.Add("HTML5");
            Courses.Add("Database");
            Courses.Add("JavaScript");
            Courses.Add("Web Development");

            if (Courses.IndexOf("C#") != -1)
            {
                //C# CLass exist in our list, perform necessary operations
            }

            // Unsorted list
            Console.WriteLine("Print unsorted list");
            foreach (var item in Courses)
            {
                Console.WriteLine(item);
            }

            // Sort the list
            Courses.Sort();
            Console.WriteLine("Print sorted list");

            foreach (var item in Courses)
            {
                Console.WriteLine(item);
            }


            Courses.RemoveAt(Courses.IndexOf("C#"));
            Courses.RemoveAt(0);

            Console.WriteLine(Courses.IndexOf("HTML5"));
            Console.ReadLine();
        }
    }
}
