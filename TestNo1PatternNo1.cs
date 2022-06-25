using System;
using System.Collections.Generic;
using System.Text;

namespace TestAndAssignmentProject1May2022
{
    class TestNo1PatternNo1
    {
        static void Main(string[] args)
        {
            int n = 4, z = 1;
            for (int i = 1; i <= n; i++)
            {
                for (int j = n; j >= i; j--)
                {
                    Console.Write (" ");
                }
                for (int k = 1; k <= z; k++)
                {
                    Console.Write(z);
                }
                z = z + 1;
                Console.WriteLine();
            }
        }
    }
}
