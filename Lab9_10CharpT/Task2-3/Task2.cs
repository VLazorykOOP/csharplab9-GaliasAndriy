namespace Lab9_10CharpT
{
    class Task2
    {
        public static void ExecuteTask() {
            Queue<Employee> lessThan10000 = new();
            Queue<Employee> greaterThanOrEqual10000 = new();

            List<Employee> employees = new()
            {
                new Employee { LastName = "Doe", FirstName = "John", MiddleName = "Smith", Gender = "Male", Age = 30, Salary = 4000 },
                new Employee { LastName = "Smith", FirstName = "Jane", MiddleName = "Doe", Gender = "Female", Age = 25, Salary = 11000 },
                new Employee { LastName = "Johnson", FirstName = "Bob", MiddleName = "Johnson", Gender = "Male", Age = 40, Salary = 7300 },
                new Employee { LastName = "Jackson", FirstName = "Peter", MiddleName = "Eugene", Gender = "Male", Age = 23, Salary = 2000 },
                new Employee { LastName = "Briana", FirstName = "Osman", MiddleName = "Fedora", Gender = "Male", Age = 40, Salary = 20000 },
                new Employee { LastName = "Damian", FirstName = "Gordon", MiddleName = "Leonardo", Gender = "Male", Age = 40, Salary = 45000 },
                new Employee { LastName = "Marquez", FirstName = "Daisie", MiddleName = "Jim", Gender = "Female", Age = 26, Salary = 3000 },
                new Employee { LastName = "Denise", FirstName = "Caspar", MiddleName = "Henry", Gender = "Male", Age = 40, Salary = 3900 },
            };

            foreach (var employee in employees)
            {
                if (employee.Salary < 10000)
                {
                    lessThan10000.Enqueue(employee);
                }
                else
                {
                    greaterThanOrEqual10000.Enqueue(employee);
                }
            }

            Console.WriteLine("Employees with salary less than 10000:");
            Console.WriteLine("----------------------------------------");
            PrintEmployees(lessThan10000);

            Console.WriteLine("Other employees:");
            Console.WriteLine("----------------------------------------");
            PrintEmployees(greaterThanOrEqual10000);
        }
        static void PrintEmployees(Queue<Employee> employees)
        {
            foreach (var employee in employees)
            {
                Console.WriteLine(employee.ToString());
            }
        }
    }
}
