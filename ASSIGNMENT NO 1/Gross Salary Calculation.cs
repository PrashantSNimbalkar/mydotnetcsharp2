using System;
using System.Collections.Generic;
using System.Text;

namespace TestAndAssignmentProject1May2022.ASSIGNMENT_NO_1
{
    class Gross_Salary_Calculation
    {
        static void Main(string[] args)
        {
            int basic, gross, da, hra;
            Console.WriteLine("Enter The  Salary");
            basic = Convert.ToInt32(Console.ReadLine());
            if (basic <= 10000)
            {
                da = (int)(basic * 0.8);
                hra = (int)(basic * 0.20);

            }
            else if (basic <= 20000)
            {
                da = (int)(basic * 0.9);
                hra = (int)(basic * 0.25);
            }
            else
            {
                da = (int)(basic * 0.95);
                hra = (int)(basic * 0.30);
            }
            gross= basic + da + hra;
            Console.WriteLine(" The Gross Salary IS:="+gross);
        }
    }
        
}

