using System;
using System.Collections;
using System.Collections.Generic;

namespace Lab9_10CharpT
{
    class Task3
    {
        public static void ExecuteTask()
        {
            ArrayList employees = GetEmployeeList();

            employees.Sort(new EmployeeSalaryComparer());

            ArrayList lessThan10000 = new();
            ArrayList greaterThanOrEqual10000 = new();

            foreach (Employee employee in employees)
            {
                if (employee.Salary < 10000)
                {
                    lessThan10000.Add(employee.Clone());
                }
                else
                {
                    greaterThanOrEqual10000.Add(employee.Clone());
                }
            }

            Console.WriteLine("Employees with salary less than 10000:");
            Console.WriteLine("----------------------------------------");
            PrintEmployees(lessThan10000);

            Console.WriteLine("Other employees:");
            Console.WriteLine("----------------------------------------");
            PrintEmployees(greaterThanOrEqual10000);
        }

        static ArrayList GetEmployeeList()
        {
            return new ArrayList
            {
                new Employee { LastName = "Doe", FirstName = "John", MiddleName = "Smith", Gender = "Male", Age = 30, Salary = 4000 },
                new Employee { LastName = "Smith", FirstName = "Jane", MiddleName = "Doe", Gender = "Female", Age = 25, Salary = 11000 },
                new Employee { LastName = "Briana", FirstName = "Osman", MiddleName = "Fedora", Gender = "Male", Age = 40, Salary = 20000 },
                new Employee { LastName = "Denise", FirstName = "Caspar", MiddleName = "Henry", Gender = "Male", Age = 40, Salary = 3900 },
            };
        }

        static void PrintEmployees(ArrayList employees)
        {
            foreach (Employee employee in employees)
            {
                Console.WriteLine(employee);
            }
        }
    }

    class EmployeeSalaryComparer : IComparer
    {
        public int Compare(object x, object y)
        {
            Employee emp1 = x as Employee;
            Employee emp2 = y as Employee;

            if (emp1 == null || emp2 == null)
            {
                throw new ArgumentException("Object is not of type Employee");
            }

            return emp1.Salary.CompareTo(emp2.Salary);
        }
    }
}
