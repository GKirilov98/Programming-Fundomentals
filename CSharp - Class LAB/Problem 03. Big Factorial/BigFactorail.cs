﻿using System;
using System.Numerics;
namespace Problem_03._Big_Factorial
{
    class BigFactorail
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            BigInteger sum = 1;
            for (int i = 1; i <= num; i++)
            {
                sum *= i;
            }
            Console.WriteLine(sum);
        }
    }
}
