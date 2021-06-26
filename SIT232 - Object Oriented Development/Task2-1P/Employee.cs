/******************************************************************************
AUTHOR:         JUSTIN BLAND
TASK:           2-1P (Employee.cs)
DATE:           20/07/2020
STATUS:         COMPLETED

REVISIONS:      20/07/2020 - FILE CREATION
******************************************************************************/

using System;
using System.Collections.Generic;
using System.Text;

namespace Task2_1P
{
    class Employee
    {
        // Variables
        private String Name;
        private double Salary;

        public Employee(String employeeName, double employeeSalary)
        {
            this.Name = employeeName;
            this.Salary = employeeSalary;
        }

        // Access Methods
        public String getName()
        {
            return this.Name;
        }

        public double getSalary()
        {
            return this.Salary;
        }

        // Methods
        public void raiseSalary(double raise)
        {
            this.Salary += raise;
            Console.WriteLine("Salary raised successfully, New Salary: $" + getSalary());
        }

        // Tax Calculation
        public double taxCalculation()
        {
            double tax = 0;
            double taxableSalary = this.Salary;

            if (this.Salary >= 0 && this.Salary <= 18200)
            {
                return tax;
            }
            else if (this.Salary >= 18201 && this.Salary <= 37000)
            {
                taxableSalary = this.Salary - 18200;
                tax = 0.19 * taxableSalary;
                return tax;
            }
            else if (this.Salary >= 37001 && this.Salary <= 90000)
            {
                taxableSalary = this.Salary - 37000;
                tax = 3572 + (0.325 * taxableSalary);
                return tax;
            }

            else if (this.Salary >= 90001 && this.Salary <= 180000)
            {
                taxableSalary = this.Salary - 90000;
                tax = 20797 + (0.37 * taxableSalary);
                return tax;
            }

            else if (this.Salary > 180000)
            {
                taxableSalary = this.Salary - 180000;
                tax = 54096 + (0.45 * taxableSalary);
                return tax;
            }

            else
            {
                return tax;
            }
        }
    }
}
