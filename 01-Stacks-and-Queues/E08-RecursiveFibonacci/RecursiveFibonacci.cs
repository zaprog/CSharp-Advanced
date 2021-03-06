﻿namespace E08_RecursiveFibonacci
{
    using System;

    public class RecursiveFibonacci
    {
        private static long[] fibonacci;
        public static void Main()
        {
            // n-th Fibonacci counting from 1 => 1 1 2 3 5...
            int n = int.Parse(Console.ReadLine()); 
            fibonacci = new long[n];
            Console.WriteLine(GetFibonacci(n - 1));
        }

        private static long GetFibonacci(int n)
        {
            if (n < 2) return 1;
            if (fibonacci[n] == 0)
            {
                fibonacci[n] = GetFibonacci(n - 1) + GetFibonacci(n - 2);
            }
            return fibonacci[n];
        }
    }
}
