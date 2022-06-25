using System;
using System.Collections.Generic;
using System.Text;

namespace TestAndAssignmentProject1May2022
{
    class TrimorphicNumber
    {static void Main(string[] args)
        {
            int num;
            Console.WriteLine("ENTER THE NUM");
           num =Convert.ToInt32(Console.ReadLine());
            int flag = 0;
            int cube = num * num * num;
            while(num!=0)
                {
                if(num%10!=cube%10)
                {
                    flag = 1;

                }
                num = num / 10;
                cube = cube / 10;
                }
            if(flag==0)
            {
                Console.WriteLine("It Is Trimorphic Number");
            }
            else
            {
                Console.WriteLine("It Is Not Trimorphic Number");
            }
        }
    }
}
