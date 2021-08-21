using System;

namespace Fibonacci
{
    class Program
    {
        static void Main(string[] args)
        {
            int previous = 0;
            int current = 1;
           
            int[] fibonacci = new int[25];
            fibonacci[0] = previous;
            fibonacci[1] = current;
            Console.WriteLine(fibonacci[0]);
            Console.WriteLine(fibonacci[1]);
             

           for (int i = 2; i<fibonacci.Length; i++)
            {
                fibonacci[i]= fibonacci[i-2] + fibonacci[i-1];
                Console.WriteLine(fibonacci[i]);


            }
        
        }
    }
}

