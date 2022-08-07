using System;
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
            var sum = numbers.Sum();
            var average = numbers.Average();
            Console.WriteLine($"Sum is {sum} and average is  {average}");
            var asc = numbers.OrderBy(num => num);
            foreach (var item in asc)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("----");
            Console.WriteLine("Asc");
            var dsc = numbers.OrderByDescending(num => num);

            Console.WriteLine("----");
            foreach (var item in dsc)
            {
                Console.WriteLine(item);
            }

            var greaterthsix = numbers.Where(num => num > 6);
            Console.WriteLine("----");
            foreach (var number in greaterthsix)
            {

                Console.WriteLine(number);
            }

            Console.WriteLine("----");

            foreach (var num in asc.Take(4))
            {
                Console.WriteLine(num);
            }

            Console.WriteLine("----");
            numbers[4] = 24; 
            foreach (var item in numbers.OrderByDescending(num =>num))
                {
                Console.WriteLine(item);
            }

            /*
          
             * Complete every task using Method OR Query syntax. 
             * You may find that Method syntax is easier to use since it is most like C#
             * Every one of these can be completed using Linq and then printing with a foreach loop.
             * Push to your github when completed!
             * 
             */

            //TODO: Print the Sum of numbers ok

            //TODO: Print the Average of numbers ok

            //TODO: Order numbers in ascending order and print to the console ok

            //TODO: Order numbers in decsending order adn print to the console ok

            //TODO: Print to the console only the numbers greater than 6 ok

            //TODO: Order numbers in any order (acsending or desc) but only print 4 of them **foreach loop only!** ok

            //TODO: Change the value at index 4 to your age, then print the numbers in decsending order

            // List of employees ****Do not remove this****
            var employees = CreateEmployees();

            //TODO: Print all the employees' FullName properties to the console only if their FirstName starts with a C OR an S and order this in acesnding order by FirstName.

            //TODO: Print all the employees' FullName and Age who are over the age 26 to the console and order this by Age first and then by FirstName in the same result.

            //TODO: Print the Sum and then the Average of the employees' YearsOfExperience if their YOE is less than or equal to 10 AND Age is greater than 35

            //TODO: Add an employee to the end of the list without using employees.Add()

            var filter = employees.Where(person => person.FirstName.ToLower().StartsWith('c'));
            Console.WriteLine("----");
           
            foreach (var person in filter)
            {
                Console.WriteLine(person.FullName);
            }

            var twentysix = employees.Where(x => x.Age < 26 ).OrderByDescending(x => x.Age).ThenBy(x=> x.FirstName) ;
            Console.WriteLine("------");
            foreach (var item in twentysix)
            {
                Console.WriteLine($"Name: {item.FullName}, Age: {item.Age}");
            }
            var sumandYOA = employees.Where(x => x.YearsOfExperience <= 10 && x.Age > 35);
            Console.WriteLine("------");
            Console.WriteLine($"Total YOE:{sumandYOA.Sum(x => x.YearsOfExperience)}");
            Console.WriteLine($"Avg YOE:{sumandYOA.Average(x => x.YearsOfExperience)}");

            employees = employees.Append(new Employee("First", "Last", 30, 10)).ToList();
            Console.WriteLine("-----");
            foreach (var item in employees)
            {
                Console.WriteLine(item.FullName);
            }
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
