using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Recursion_examples
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[]{1,3,4,5,6,7,8,9};
            Console.WriteLine(IsAllSameParity(25788));
            Console.WriteLine(SumOfFirst(arr , 5));
            Console.WriteLine(IsIncreasingOrder(arr));
            Console.WriteLine(LowercaseLetters("ABRAKADABRA"));
            Console.WriteLine(ReversedWord("ABRAKADABRA"));

            //int[] arr = new int[] {1, 4, -2, 7, 99, 0};
            //Console.WriteLine(Max(arr, arr.Length-1));
            Console.WriteLine(Factorial(10));
        }

        static bool IsAllSameParity(int n)
        {
            int lastDigit = n % 10;
            return IsAllSameParityInner(n / 10, lastDigit % 2 == 0);
        }
        static bool IsAllSameParityInner(int n, bool firstParity)  // true if even, false if odd
        {
            int lastDigit = n % 10;
            if (n < 10)
            {
                return ((n % 2 == 0) == firstParity);
            }
            if ((lastDigit % 2 == 0) != firstParity)
            {
                return false;
            }
            else
            {
                return IsAllSameParityInner(n / 10, firstParity);
            }
        }

        static int SumOfFirst(int[] arr , int i)
        {
            if (i == 0)
                return arr[0];

            return SumOfFirst(arr, i-1) + arr[i];
        }

        static bool IsIncreasingOrder(int[] arr)
        {
            int i = arr.Length;
            return IsIncreasingOrderInner(arr, i-1);
        }

        //static bool IsIncreasingOrderInner(int[] arr, int i)
        //{
        //    if(i == 0)
        //    {
        //        return true;
        //    }
        //    if(arr[i] <= arr[i-1])
        //        return false;

        //    return isIncreasingOrderInner(arr, i - 1);
        //}

        static bool IsIncreasingOrderInner(int[] arr, int i)
        {
            if (i == 0)
            {
                return true;
            }
            return arr[i] <= arr[i - 1] && IsIncreasingOrderInner(arr, i - 1);
        }

        static int LowercaseLetters(string word)
        {
            return LowercaseLettersInner(word, word.Length - 1);
        }

        static int LowercaseLettersInner(string word, int i)
        {
            if (i == 0)
            {
                if (word[0] >= 'a' && word[0] <= 'z')
                {
                    return 1;
                }
                return 0;
            }
            if (word[i] >= 'a' && word[i] <= 'z')
            {
                return 1 + LowercaseLettersInner(word, i - 1);
            }
            else
            {
                return LowercaseLettersInner(word, i - 1);
            }

            //string s = "" + word[i];
            //if (i == 0)
            //{
            //    if (s == s.ToLower())
            //    {
            //        return 1;
            //    }
            //    return 0;
            //}
            //if(s == s.ToLower())
            //{
            //    return 1+ lowercaseLettersInner(word, i-1);
            //}
            //else
            //{
            //    return LowercaseLettersInner(word, i-1);
            //}
        }

        static string ReversedWord(string word)
        {
            //return ReversedWordInner(word, word.Length - 1);

            if (word.Length == 1)
                return word;

            return word[word.Length - 1] + ReversedWord(word.Remove(word.Length - 1));
        }

        static string ReversedWordInner(string word, int i)
        {
            if (i == 0)
                return "" + word[i];

            return word[i] + ReversedWordInner(word, i - 1);

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
