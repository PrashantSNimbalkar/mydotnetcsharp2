using System;

namespace TestAndAssignmentProject1May2022
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 1;
            while(i<=5)
            { 
                int j = 1;
                while(j<5)
                { 
                    if (j == 2)
                   {
                        Console.WriteLine(j);
                        break;
                   }
                    j++;
                }
            
            }
            Console.WriteLine(i);
        }
    }
}



