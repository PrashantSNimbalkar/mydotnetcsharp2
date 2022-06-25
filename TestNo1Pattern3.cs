using System;
using System.Collections.Generic;
using System.Text;

namespace TestAndAssignmentProject1May2022
{
    class TestNo1Pattern3
    {
        static void Main(string[] args)
        {

            int n = 5;
            for (int i = n; i >= 1; i--)
            {
                for (int j = n-1; j >= i; j--)
                {
                    Console.Write(" ");
                }
                for (int k = 1; k <= i ; k++)
                {
                    Console.Write(k);
                }
            
                Console.WriteLine();
            }
        }
    }
}
