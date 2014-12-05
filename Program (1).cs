using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RecursionExample
{
    class Program
    {
        static void Main(string[] args)
        {
            //int[] arr = new int[] {1, 4, -2, 7, 99, 0};
            //Console.WriteLine(Max(arr, arr.Length-1));

            Console.WriteLine(Factorial(10));
        }

        static int Mult(int a, int b)
        {
            if (b == 1)
            {
                return a;
            }
            return Mult(a, b - 1) + a;
        }

        static int Fibo(int n)
        {
            if (n == 1)
            {
                return 0;
            }
            else if (n == 2)
            {
                return 1;
            }
            return Fibo(n - 1) + Fibo(n - 2);
        }

        static int Max(int[] arr, int n)
        {
            if (n == 0)
                return arr[0];
            return Math.Max(arr[n], Max(arr, n - 1));
        }


        static int Factorial(int n)
        {
            if(n == 0)
                return 1;

            return n * Factorial(n-1);
        }

        static int CountLines(int[,] arr, int n, int i)
        {
            if (i == 0)
            {
                if (IsNunOnLine(arr, n, i, arr.GetLength(1) - 1))
                {
                    return 1;
                }
                else
                {
                    return 0;
                }
            }

            if (IsNunOnLine(arr, n, i, arr.GetLength(1) - 1))
            {
                return 1 + CountLines(arr, n, i - 1); ;
            }
            else
            {
                return 0 + CountLines(arr, n, i - 1);
            }
        }

        static bool IsNunOnLine(int[,] arr, int n, int i, int j)
        {
            if (j == 0)
            {
                return arr[i, j] == n;
            }

            if (arr[i,j] == n)
            {
                return true;
            }
            return IsNunOnLine(arr, n, i, j - 1);
        }
    }
}
