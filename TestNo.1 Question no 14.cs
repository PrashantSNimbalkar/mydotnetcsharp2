using System;
using System.Collections.Generic;
using System.Text;

namespace TestAndAssignmentProject1May2022
{
    class TestNo
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter The Number:");
            int num = Convert.ToInt32(Console.ReadLine());
            int k = 1;
            int sum = 0;
            for(int i=1;i<=num;i++)
            {
                k = k * i;
                sum = sum + k;
            }
            Console.WriteLine(sum);
        }
    }
}

