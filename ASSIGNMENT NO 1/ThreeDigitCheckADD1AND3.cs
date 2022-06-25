using System;
using System.Collections.Generic;
using System.Text;

namespace TestAndAssignmentProject1May2022.ASSIGNMENT_NO_1
{
    class ThreeDigitCheckADD1AND3
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter The NUMBER");
            int num = Convert.ToInt32(Console.ReadLine());
            int t1, f, m,l,sum = 0;
            if((num>99)&&(num<=999))
            {
                Console.WriteLine("Enter The NUMBER IS 3 DIGIT Number");
                f = num / 100;
                t1 = num % 100;
                l= t1 % 10;
                m = t1 / 10;
                sum = f + l;
                Console.WriteLine("Sum Of 1st And 3RD Digit Number IS:="+sum);
            }
            else
            {
                Console.WriteLine("Enter The NUMBER IS NOT A 3 DIGIT Number");
            }
        }
    }
}
