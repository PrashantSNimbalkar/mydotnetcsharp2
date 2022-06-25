using System;
using System.Collections.Generic;
using System.Text;

namespace TestAndAssignmentProject1May2022.ASSIGNMENT_NO_3
{
    class PRODUCTSOFDIGITSIN_NUMBER
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter The NUMBER");
            int num = Convert.ToInt32(Console.ReadLine());
            int product = 1;
            for(;num>0;num=num/10)
            {
                int r = num % 10;
                product = product * r;
            }
            Console.WriteLine(product);
        }
    }
}
