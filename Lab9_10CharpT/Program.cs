﻿namespace Lab9_10CharpT;

internal class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Lab9 C# ");
        Console.WriteLine("-------------------------------------------------------");
        Console.WriteLine("1. Postfix to prefix");
        Console.WriteLine("2. Class Queue. Employees");
        Console.WriteLine("3. ArrayList and interfaces");
        Console.WriteLine("4. Music disks");
        Console.WriteLine("-------------------------------------------------------");

        try
        {
            Console.Write("Choose a task: ");
            int choice = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("");
            switch (choice)
            {
                case 1:
                    TasksUsage.Program1();
                    Console.WriteLine("");
                    break;
                case 2:
                    TasksUsage.Program2();
                    Console.WriteLine("");
                    break;
                case 3:
                    TasksUsage.Program3();
                    Console.WriteLine("");
                    break;
                case 4:
                    TasksUsage.Program4();
                    Console.WriteLine("");
                    break;
                default:
                    Console.WriteLine("Task not found.");
                    break;
            }
        }
        catch (Exception e)
        {
            Console.WriteLine("Error: " + e.Message);
        }
    }
}
