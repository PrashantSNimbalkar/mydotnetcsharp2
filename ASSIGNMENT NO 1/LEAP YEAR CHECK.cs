using System;
using System.Collections.Generic;
using System.Text;

namespace TestAndAssignmentProject1May2022.ASSIGNMENT_NO_1
{
    class LEAP_YEAR_CHECK
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter The Year");
            int year = Convert.ToInt32(Console.ReadLine());
            if(year%4==0)
            {
                Console.WriteLine("Leap Year");
            }
            else if (year%100==0)
            {
                Console.WriteLine("Not A Leap Year");
            }
            else if (year % 400== 0)
            {
                Console.WriteLine("Not A Leap Year");
            }
            else 
            {
                Console.WriteLine("Not A Leap Year");
            }
        }
    }
}

