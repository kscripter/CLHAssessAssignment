using System;
namespace Employee
{
    public class Employee
    {

        private double Salary;//create a variable
        private int DailyWorkHours;//create another variable

        //create a method to get the salary and work hours
        public double GetSalary_WorkHours(double salary, int dailyWorkHours)
        {
            Salary = salary;
            DailyWorkHours = dailyWorkHours;
            AddSalary();
            AddWork();

            return Salary;
        }

        //a method to calculate salary
        private void AddSalary()
        {
            if (Salary < 500)
            {
                Salary += 10;
            }
        }

        //a method to calculate the work hours
        private void AddWork()
        {
            if (DailyWorkHours > 6)
            {
                Salary += 5;
            }
        }

    }
}
