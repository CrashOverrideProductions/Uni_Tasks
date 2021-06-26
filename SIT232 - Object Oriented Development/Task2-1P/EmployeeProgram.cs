/******************************************************************************
AUTHOR:         JUSTIN BLAND
TASK:           2-1P (EmployeeProgram.cs)
DATE:           20/07/2020
STATUS:         COMPLETED

REVISIONS:      20/07/2020 - FILE CREATION
******************************************************************************/
using System;
using System.Collections.Generic;
using System.Text;

namespace Task2_1P
{
    class EmployeeProgram
    {
        static void Main(string[] args)
        {
            Employee timEmployee = new Employee("Tim", 45000);
            Employee paulEmployee = new Employee("Paul", 184000);

            Console.WriteLine("Employee Name: " + timEmployee.getName() + "\nGross Salary: $"
                + timEmployee.getSalary() + "\nTax Payable: $" + timEmployee.taxCalculation());
            Console.WriteLine();
            Console.WriteLine("Employee Name: " + paulEmployee.getName() + "\nGross Salary: $"
                + paulEmployee.getSalary() + "\nTax Payable: $" + paulEmployee.taxCalculation());
            Console.ReadLine();

            Console.WriteLine();
            timEmployee.raiseSalary(25000);
            Console.WriteLine("Employee Name: " + timEmployee.getName() + "\nGross Salary: $"
                + timEmployee.getSalary() + "\nTax Payable: $" + timEmployee.taxCalculation());

            Console.ReadLine();
        }
    }
}
