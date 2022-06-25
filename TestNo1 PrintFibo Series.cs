using System;
using System.Collections.Generic;
using System.Text;

namespace TestAndAssignmentProject1May2022
{
    class TestNo1_PrintFibo_Series
    {
        static void Main(string[] args)
        {
            int n1 = 0;
            int n2 = 1;
            int n3;
            int num = 20;
            for(int i=1;i<=num;i++)
            {
                n3 = n1 + n2;
                Console.WriteLine(n3);
                n1 = n2;
                n2 = n3;
            }

        }
    }
}
