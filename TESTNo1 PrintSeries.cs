using System;
using System.Collections.Generic;
using System.Text;

namespace TestAndAssignmentProject1May2022
{
    class TESTNo1_PrintSeries
    {
        static void Main(string[] args)
        {
            int i, j;
            for(i=1;i<=11;i++)
            {
                j = 2;
                Console.WriteLine((i * i * j ));
                j = j + 1;
            }
        }
    }
}

