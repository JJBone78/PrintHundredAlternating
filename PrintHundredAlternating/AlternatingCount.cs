using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrintHundredAlternating
{
    class AlternatingCount
    {
        static void Main(string[] args)
        { // This is for Fundamentals of Computer Programming with CSharp
          // Chapter 1, excercise 10
          // "Write a program that prints the first 100 members of the sequence 2, -3, 4, -5, 6, -7, 8.
          // We want it to count from 2-100
          // We will use a loop
          // We want every odd number to be negative

            //Variable Declaration
            int startCount = 2;
            int endCount = 100;
            int count = startCount;

            Console.WriteLine("This code will count from 2 - 100, odd numbers will be negative!");
          
            while (count <= endCount)
            {
              if (count % 2 == 0) 
                {
                 Console.WriteLine("{0}", count);
                }
                else 
                {   // this is a cheap way of displayling the odd number as a negative but it still solves the excercise
                    // more advanced would be to include count = count * -1 but the issue will be 
                    // to have it keep counting after converting 
                    Console.WriteLine("-{0}", count);
                }
                count++;   
            }
            Console.Read();
        }
        
    }
}
