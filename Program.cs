using EmployeesPayment.Src;
using System;
using System.Globalization;

using System.Collections.Generic;

namespace EmployeesPayment
{
    class Program
    {      

        static void Main(string[] args)
        {       
            List<Employee> employees = new List<Employee>();


            Console.WriteLine("Hello World!");


            Console.WriteLine("Enter the number of employees: ");
            int length = int.Parse(Console.ReadLine());
            Console.WriteLine("");

            for (int i = 0; i < length; i++)
            {
                //Console.WriteLine("");

                Console.Write($"Employee #{i} data :\n Outsourced (y/n)?: ");
                string quetion = Console.ReadLine();

                if (quetion.Contains("y") || quetion.Contains("Y"))
                {
                    Employee employee = CreateNewEmployee(i);  

                    Console.WriteLine("Enter outsourced: ");
                    double vh = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture );

                    employees.Add(new OutsourceEmployee(employee.Name, employee.ValuePerHour, employee.Hours,vh ) );


                }
                else
                {

                    employees.Add(CreateNewEmployee(i));

                }

            }
       
            //List Employees
            Console.WriteLine("---- List Employees ---");
            foreach (var item in employees)
            {
                Console.WriteLine(item + "- €"+ item.Payment().ToString("F2", CultureInfo.InvariantCulture));
            }
        }

        public static Employee CreateNewEmployee(int index)
        {
            Console.WriteLine($"Enter Name Employee #{index}: ");
            string name = Console.ReadLine();

            Console.WriteLine($"Hour Employee #{index}: ");
            int h = int.Parse(Console.ReadLine());

            Console.WriteLine($"Value per Hour Employee #{index}: ");
            double vh = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            // employees.Add(new Employee(name: name, valuePerHour: vh, hours: h));

            return new Employee(name: name, valuePerHour: vh, hours: h);
        }
    }
}
