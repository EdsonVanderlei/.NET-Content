using Identidade_Udemy.Entities;
using Identidade_Udemy.Entities.Enums;
using System;
using System.Dynamic;
using System.Globalization; 
namespace Identidade_Udemy
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter department's name");
            string deptName = Console.ReadLine();
           Console.WriteLine("Name: ");
            string name = Console.ReadLine();
            Console.WriteLine("Level (Junior/MidLevel/Senior):  ");
            WorkerLevel level = Enum.Parse<WorkerLevel>(Console.ReadLine());
            Console.WriteLine("Base salary: ");
            double baseSalary = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

            Department dept = new Department(deptName);
            Worker worker = new Worker(name, level, baseSalary, dept);

            Console.WriteLine("How many contracts to this worker ? ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Enter #{n} contract data:");
                Console.Write("Date (DD/MM/YYYY):  ");
                DateTime date = DateTime.Parse(Console.ReadLine());
                Console.Write("Value per hour:  ");
                double valuePerHour = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
                Console.Write("Duration (hours): ");
                int hours = int.Parse(Console.ReadLine());

                HourContract contract = new HourContract(date,valuePerHour,hours);

                worker.AddContract(contract);
            }

            Console.WriteLine();
            Console.Write("Enter month and year to calculate income (MM/YYYY):  ");
            string[] monthAndYear = Console.ReadLine().Split("/");

            int month = int.Parse(monthAndYear[0]);
            int year = int.Parse(monthAndYear[1]);

            Console.WriteLine("Name " + worker.Name);
            Console.WriteLine("Department " + worker.Department.Name) ;
            Console.WriteLine("Income for " + month + "/" + year + ": " + worker.Income(year, month).ToString("F2", CultureInfo.InvariantCulture));


        }
    }
}
