using System;
using System.Collections.Generic;
using System.Text;

namespace TestAndAssignmentProject1May2022.ASSIGNMENT_NO_3
{
    class PALINDROMEPRINT1TO500
    {
        static void Main(string[] args)
        {
            int r1 = 1;
            int r2 = 500;
            int num1 = 0;
            int num2 = 0;
            for(int i=r1;i<=r2;i++)
            {
                num1 =1;
                num2 = 0;
            }
            while(num1!=0)
            {
                int rem = num1 % 10;
                num1 = num1 / 10;
                num2 = num2 * 10 + rem;
            }
            if(1==num2)
            {
                Console.WriteLine(1+"  ");
            }
        }
    }
}
