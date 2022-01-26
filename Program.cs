using EmployeesPayment.Src;
using System;
using System.Collections.Generic;

namespace EmployeesPayment
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Hello World!");

            List<Employee> employees = new List<Employee>();


            employees.Add(new Employee());
            employees.Add(new Employee(name: "Carlos", valuePerHour: 10.3, hours: 8));
            employees.Add(new Employee(name: "Andrade Carlos", valuePerHour: 18.3, hours: 5));
            employees.Add(new Employee(name: "Nvemba Carlos", valuePerHour: 14.3, hours: 4));

            //List Employees
            Console.WriteLine("---- List Employees ---");
            foreach (var item in employees)
            {
                Console.WriteLine(item);
            }
        }
    }
}
