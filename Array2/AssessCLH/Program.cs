using System;

namespace AssessCLH
{
    class Program
    {
        static void Main(string[] args)
        {

//  Every element in an array has the same type.
//  The array size is fixed after an array reference variable is declared.
//  The array size is fixed after it is created.
//  The elements in an array must be a primitive data type.
//  The elements in an array cannot be integers
//1.True
//2.False
//3.True
//4.False
//5.False



            int x = 30; //a variable is defined and declared
            int[] students = new int[x];// an array is defined called "student" and create array and assigned to array variable 'x'
            x = 60; // variable 'x' is a reassigned value '60' 
            Console.WriteLine("x is " + x); // a print statement to print the value of 'x' 60
            Console.WriteLine("The number of student is " + students.Length);// value is 30


        }
    }
}
