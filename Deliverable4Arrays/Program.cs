/*
Author: Diego Fernandez
Date: 2/9/2023
Description: This program will computer the first 25 numbers of the fibbonaci sequence using an array
*/

namespace Deliverable_4
{
    class Program
    {
        static void Main(string[] args)
        {
           //create array that stores fib numbers
            int a = 25;
            int[] fib = new int[a];
            fib[0] = 0;
            fib[1] = 1;

            //add the previous to number to create fib sequence
            for (int i = 2; i < a; i++)
            {
                fib[i] = fib[i - 2] + fib[i - 1];
            }

            for(int i = 0; i < a; i++)
            {
                Console.WriteLine("Fibonacci number " + "(" + i +") = " + fib[i]);
            }


        }
    }
}