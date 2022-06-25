using System;
using System.Collections.Generic;
using System.Text;

namespace TestAndAssignmentProject1May2022
{
    class TestNo1_QuestionNo
    {
        static void Main(string[] args)
        {   int a=1;
            Console.WriteLine("Numbers In 1 TO 100 Which Is Not Divisible By 5 AND 10:");
            for (int i = 1; i <= 100; i++)
            {
                if ((i % 5 == 0) || (i % 10== 0))
                {
                    Console.WriteLine();
                    a = a + 1;
                }
                else
                {
                    Console.WriteLine(a);
                    a = a + 1;
                }
            }
        }
    }
}
