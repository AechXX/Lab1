using System;
using System.Collections.Generic;
using System.Text;

namespace Department_Lab_Stuff
{
    class Employee
    {
        string firstName;
        string lastName;
        string dept;

        public Employee(string firstName, string lastName, string dept)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.dept = dept;

            if (string.IsNullOrEmpty(dept))
            {
                dept = "IT";
            }

            Console.WriteLine("First Name: " + firstName + " | Last Name: " + lastName + " | Department: " + dept);
            Console.ReadLine();
        }
    }
}
