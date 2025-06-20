﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace LinqExercise
{
    class Program
    {
        //Static array of integers
        private static int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 0 };

        static void Main(string[] args)
        {
            /*
             * 
             * Complete every task using Method OR Query syntax. 
             * You may find that Method syntax is easier to use since it is most like C#
             * Every one of these can be completed using Linq and then printing with a foreach loop.
             * Push to your github when completed!
             * 
             */

            //TODO: Print the Sum of numbers

            Console.WriteLine("Sum of numbers:");
            Console.WriteLine(numbers.Sum());
            Console.WriteLine();



            //TODO: Print the Average of numbers

            Console.WriteLine("Average of all the numbers:v");
            Console.WriteLine(numbers.Average());
            Console.WriteLine();

            //TODO: Order numbers in ascending order and print to the console

            Console.WriteLine("Numbers in ascending order");
            numbers.OrderBy(x => x).ToList().ForEach(x => Console.WriteLine(x));
            Console.WriteLine();

            //TODO: Order numbers in descending order and print to the console

            Console.WriteLine("Numbers in descending order");
            numbers.OrderBy(x => x).Reverse().ToList().ForEach(x => Console.WriteLine(x));
            Console.WriteLine();

            //TODO: Print to the console only the numbers greater than 6

            Console.WriteLine("Numbers greater than 6:");
            numbers.Where(x => x > 6).ToList().ForEach(x => Console.WriteLine(x));
            Console.WriteLine();


            //TODO: Order numbers in any order (ascending or desc) but only print 4 of them **foreach loop only!**

            Console.WriteLine("First 4 numbers in ascending order:");
            numbers.OrderBy(x => x).Take(4).ToList().ForEach(x => Console.WriteLine(x));
            Console.WriteLine();

            //TODO: Change the value at index 4 to your age, then print the numbers in descending order

            Console.WriteLine("Numbers in descending order after changing index 4 to age:");
            numbers[4] = 28;
            Console.WriteLine("Updated number at index 4: " + numbers[4]);
            numbers.OrderByDescending(x => x).ToList().ForEach(x => Console.WriteLine(x));
            Console.WriteLine();



            // List of employees ****Do not remove this**** 
            var employees = CreateEmployees();

            //TODO: Print all the employees' FullName properties to the console only if their FirstName starts with a C OR an S and order this in ascending order by FirstName.

            Console.WriteLine("Employees with FirstName starting with C or S:");
            employees
                .Where(e => e.FirstName.StartsWith("C") || e.FirstName.StartsWith("S"))
                .OrderBy(e => e.FirstName)
                .ToList()
                .ForEach(e => Console.WriteLine(e.FullName));
            Console.WriteLine();


            //TODO: Print all the employees' FullName and Age who are over the age 26 to the console and order this by Age first and then by FirstName in the same result.

            Console.WriteLine("Employees over age 26 ordered by Age and then FirstName:");
            employees
                .Where(e => e.Age > 26)
                .OrderBy(e => e.Age)
                .ThenBy(e => e.FirstName)
                .ToList()
                .ForEach(e => Console.WriteLine($"{e.FullName}, Age: {e.Age}"));
            Console.WriteLine();

            //TODO: Print the Sum of the employees' YearsOfExperience if their YOE is less than or equal to 10 AND Age is greater than 35.
            Console.WriteLine("Sum of Years Of Experience for employees with YOE <= 10 and Age > 35:");
            int employeeSum =
            employees
                .Where(e => e.YearsOfExperience <= 10 && e.Age > 35)
                 .Sum(e => e.YearsOfExperience);
                
            Console.WriteLine(employeeSum);


            //TODO: Now print the Average of the employees' YearsOfExperience if their YOE is less than or equal to 10 AND Age is greater than 35.
            Console.WriteLine("Average of Years Of Experience for employees with YOE <= 10 and Age > 35:");
            double employeeAverage =
                employees
                .Where(e => e.YearsOfExperience <= 10 && e.Age > 35)
                .Average(e => e.YearsOfExperience);
            Console.WriteLine(employeeAverage);
            Console.WriteLine();


            //TODO: Add an employee to the end of the list without using employees.Add()
            Employee newEmployee = new Employee();
            newEmployee.FirstName = "John";
            newEmployee.LastName = "Doe";
            newEmployee.Age = 30;
            newEmployee.YearsOfExperience = 5;

            Console.WriteLine();
            Console.WriteLine();


            employees.Append(newEmployee).ToList().ForEach(e => Console.WriteLine(e.FullName));
            Console.WriteLine();

            Console.WriteLine("Original List");

            foreach (var employee in employees)
            {
                Console.WriteLine($"{employee.FullName}, Age: {employee.Age}, YOE: {employee.YearsOfExperience}");
            }

            Console.WriteLine();

            Console.ReadLine();
        }

        #region CreateEmployeesMethod
        private static List<Employee> CreateEmployees()
        {
            List<Employee> employees = new List<Employee>();
            employees.Add(new Employee("Cruz", "Sanchez", 25, 10));
            employees.Add(new Employee("Steven", "Bustamento", 56, 5));
            employees.Add(new Employee("Micheal", "Doyle", 36, 8));
            employees.Add(new Employee("Daniel", "Walsh", 72, 22));
            employees.Add(new Employee("Jill", "Valentine", 32, 43));
            employees.Add(new Employee("Yusuke", "Urameshi", 14, 1));
            employees.Add(new Employee("Big", "Boss", 23, 14));
            employees.Add(new Employee("Solid", "Snake", 18, 3));
            employees.Add(new Employee("Chris", "Redfield", 44, 7));
            employees.Add(new Employee("Faye", "Valentine", 32, 10));

            return employees;
        }
        #endregion
    }
}
