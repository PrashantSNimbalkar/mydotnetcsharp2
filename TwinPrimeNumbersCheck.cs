using System;
using System.Collections.Generic;
using System.Text;

namespace TestAndAssignmentProject1May2022
{
    class TwinPrimeNumbersCheck
    {
        static void Main(string[] args)
        {
            int num1, num2;
            int c1 = 0;
            int c2 = 0;
            int d;
            Console.WriteLine("Enter The Number 1:");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter The Number 2:");
            num2 = Convert.ToInt32(Console.ReadLine());
            for(int i=1;i<num1;i++)
            {
                if(num1%i==0)
                { 
                    c1++; 
                }
            }
            for(int j=1;j<=num2;j++)
            {
                if(num2%j==0)
                    {
                    c2++;
                    }
            }
            d =num1 - num2;
            if((d==2)&&(c1==2)&&(c2==2))
            {
                Console.WriteLine("TWIN PRIME NUMBER:");
            }
            else
            {
                Console.WriteLine("NOT A TWIN PRIME NUMBER:");
            }


        }
    }
}

