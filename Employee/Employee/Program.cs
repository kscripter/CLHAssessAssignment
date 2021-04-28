using System;

namespace Employee
{
    class MainClass
    {
        public static void Main(string[] args)
        {

            //an instance of the class Employee
            Employee employee = new Employee();

            //ask for user input for salary
            Console.Write("Enter Employee Salary: ");
            double salary = Convert.ToDouble(Console.ReadLine());

            //ask for user input for work hours
            Console.Write("Enter employee work hours/day: ");
            int workHours = Convert.ToInt32(Console.ReadLine());

            //a variable to call "GetInfo" method and store in a new variable
            double newSalary = employee.GetSalary_WorkHours(salary, workHours);


            // printout the new salary
            Console.WriteLine($"Employee's new salary is ${newSalary}");



        }
    }
}
