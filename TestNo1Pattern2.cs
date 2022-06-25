using System;
using System.Collections.Generic;
using System.Text;

namespace TestAndAssignmentProject1May2022
{
    class TestNo1Pattern2
    {
        static void Main(string[] args)
        {
            
            int m = 1;
            for (int i = 5; i >=1; i--)
            {
                for (int j =1; j <=m; j++)
                {
                    Console.Write ("");
                }
                for (int k = 1; k <= 2*i-i; k++)
                {
                    Console.Write("*");
                }
                m++;
                Console.WriteLine();
            }
        }
    }
}

