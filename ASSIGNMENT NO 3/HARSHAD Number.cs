using System;
using System.Collections.Generic;
using System.Text;

namespace TestAndAssignmentProject1May2022.ASSIGNMENT_NO_3
{
    class HARSHAD_Number
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter The NUMBER");
            int num = Convert.ToInt32(Console.ReadLine());
            int rem = 0;
            int sum = 0;
            int n = num;
            while(num>0)
            {
                rem = num % 10;
                sum = sum + rem;
                num = num / 10;
            }

            if(n%sum==0)
            {
                Console.WriteLine("IT IS A HARSHAD NUMBER");
            }
            else
            {
                Console.WriteLine("IT IS NOT HARSHAD NUMBER");
            }
        }
    }
}
