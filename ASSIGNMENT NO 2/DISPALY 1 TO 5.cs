using System;
using System.Collections.Generic;
using System.Text;

namespace TestAndAssignmentProject1May2022.ASSIGNMENT_NO_2
{
    class DISPALY_1_TO_5
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ENTER ANY DIGIT BETWEEN 1 TO 5:");
            int num = Convert.ToInt32(Console.ReadLine());
            switch (num)
            {
                case 1: Console.WriteLine("ONE");
                    break;  
            
             
                case 2: Console.WriteLine("TWO");
                break;
           
            
                case 3: Console.WriteLine("THREE");
                break;
            
            
                case 4: Console.WriteLine("FOUR");
                break;
           
        
                case 5: Console.WriteLine("FIVE");
                break;

                default: Console.WriteLine("WRONG DATA");
                    break;
            }
        }
        
    }
}

