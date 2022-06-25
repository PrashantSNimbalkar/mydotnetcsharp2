using System;
using System.Collections.Generic;
using System.Text;

namespace TestAndAssignmentProject1May2022.ASSIGNMENT_NO_3
{
    class Gcd_And_LCM_Checl
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ENTER NUMBER 1:");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("ENTER NUMBER 2:");
            int num2 = Convert.ToInt32(Console.ReadLine());
            int gcd,lcm,rem,numer,deno;
            if(num1>num2)
            {
                numer = num1;
                deno = num2;
            }
            else
            {
                numer = num2;
                deno = num1;
            }
            rem = numer + deno;
            while(rem!=0)
            {
                numer = deno;
                deno = rem;
                rem = numer % deno;
            }
            gcd = deno;
            lcm = (num1 * num2) / 2;
            Console.WriteLine("GCD IS:" + gcd);
            Console.WriteLine("LCM IS:" + lcm);
        }
    }
}


