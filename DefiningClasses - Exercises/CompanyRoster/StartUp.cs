using System;
using System.Collections.Generic;
using System.Linq;

namespace CompanyRoster
{
    public class StartUp
    {
        public static void Main()
        {
            int numberOfEmployee = int.Parse(Console.ReadLine());
            List<Employee> employees = new List<Employee>();

            for (int i = 0; i < numberOfEmployee; i++)
            {
                string[] employeeInfo = Console.ReadLine()
                    .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(x => x.Trim())
                    .ToArray();

                Employee employee = new Employee(employeeInfo[0], decimal.Parse(employeeInfo[1]), employeeInfo[2], employeeInfo[3]);

                if (employeeInfo.Length > 5)
                {
                    employee.Age = int.Parse(employeeInfo[5]);
                }

                if (employeeInfo.Length > 4)
                {
                    string ageOrEmail = employeeInfo[4];
                    if (ageOrEmail.Contains("@"))
                    {
                        employee.Email = ageOrEmail;
                    }
                    else
                    {
                        employee.Age = int.Parse(ageOrEmail);
                    }
                }
                employees.Add(employee);
            }
            var result = employees.GroupBy(e => e.Department)
                .Select(e => new
                {
                    Department = e.Key,
                    AverageSalary = e.Average(emp => emp.Salary),
                    Employees = e.OrderByDescending(emp => emp.Salary)

                }).OrderByDescending(e => e.AverageSalary).FirstOrDefault();


            Console.WriteLine($"Highest Average Salary: {result.Department}");
            foreach (Employee employee in result.Employees)
            {
                Console.WriteLine($"{employee.Name} {employee.Salary:F2} {employee.Email} {employee.Age}");
            }
        }
    }
}
