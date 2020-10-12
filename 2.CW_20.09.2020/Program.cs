using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _2.CW_20._09._2020
{
    public class Program
    {
        static void Main(string[] args)
        {
            //Task1();

            //Task2();

            //Task3();

            //Task3_2();

            //Task4();

            //Task5();
        }

        private static void Task5()
        {
            FillArrAndPrint(out var arr);
            FindPositionOfMinAndMaxValues(arr, out var min, out var max);
            var left = min;
            var right = max;
            SwapTulpesIfFirstArgTulpeSituatedAfterSecongArgInArr(ref left, ref right);
            var sum = CalcSumBetweenMinAndMax(arr, left, right);
            Console.WriteLine(sum);
        }

        private static void FillArrAndPrint(out int[,] arr)
        {
            var rand = new Random();
            arr = new int[5, 5];
            for (int i = 0; i < arr.GetLength(0); ++i)
            {
                for (int j = 0; j < arr.GetLength(1); ++j)
                {
                    arr[i, j] = rand.Next(-100, 100);
                    Console.Write($"{arr[i, j]} ");
                }
                Console.WriteLine();
            }
        }

        private static void FindPositionOfMinAndMaxValues(int[,] arr, out Tuple<int, int> min, out Tuple<int, int> max)
        {
            min = new Tuple<int, int>(0, 0);
            max = new Tuple<int, int>(0, 0);
            for (int i = 0; i < arr.GetLength(0); ++i)
            {
                for (int j = 0; j < arr.GetLength(1); ++j)
                {
                    if (arr[i, j] < arr[min.Item1, min.Item2])
                        min = new Tuple<int, int>(i, j);

                    if (arr[i, j] > arr[max.Item1, max.Item2])
                        max = new Tuple<int, int>(i, j);
                }
            }
        }

        public static void SwapTulpesIfFirstArgTulpeSituatedAfterSecongArgInArr(ref Tuple<int, int> earlierArrEl, ref Tuple<int, int> laterArrEl)
        {
            if (earlierArrEl.Item1 < laterArrEl.Item1)
                return;

            if (earlierArrEl.Item1 == laterArrEl.Item1 && earlierArrEl.Item2 <= laterArrEl.Item2)
                return;

            var tmp = earlierArrEl;
            earlierArrEl = laterArrEl;
            laterArrEl = tmp;
        }

        public static int CalcSumBetweenMinAndMax(int[,] arr, Tuple<int, int> left, Tuple<int, int> right)
        {
            var sum = 0;
            for (int i = left.Item1; i <= right.Item1; ++i)
            {
                var leftJ = 0;
                if (i == left.Item1)
                    leftJ = left.Item2 + 1;

                var rightJ = arr.GetLength(1) - 1;
                if (i == right.Item1)
                    rightJ = right.Item2 - 1;

                for (int j = leftJ; j <= rightJ; ++j)
                {
                    sum += arr[i, j];
                }
            }
            return sum;
        }

        private static void Task4()
        {
            Console.Write("Enter a text: ");
            var inpText = Console.ReadLine();
            var res = inpText.Split(" ");
            Console.Write($"There are {res.Length} words was inputted");
        }

        private static void Task1()
        {
            var A = new double[5];
            Console.Write("Enter 5 numbers (Separate them by space symbol): = ");
            var input = Console.ReadLine();
            var inpArr = input.Split(' ');
            var counter = 0;
            foreach (var num in inpArr)
            {
                if (counter == A.Length)
                    break;
                if (int.TryParse(num, out var result))
                    A[counter++] = result;
            }
            foreach (var num in A)
                Console.Write($"{num} ");

            var rand = new Random();
            var B = new double[3, 4];

            Console.WriteLine();
            for (int i = 0; i < B.GetLength(0); ++i)
            {
                for (int j = 0; j < B.GetLength(1); ++j)
                {
                    B[i, j] = rand.NextDouble();
                    Console.Write($"A[{i},{j}] = {B[i, j]}");
                }
                Console.WriteLine();
            }

            double sum = 0, mult = 1, summEvenElemA = 0, sumOddColElemB = 0;
            foreach (var num in A)
            {
                sum += num;
                mult *= num;
                if (num % 2 == 0)
                    summEvenElemA += num;
            }
            var commonValues = new List<double>();
            for (int i = 0; i < B.GetLength(0); ++i)
            {
                for (int j = 0; j < B.GetLength(1); ++j)
                {
                    sum += B[i, j];
                    mult *= B[i, j];
                    if (A.Contains<double>(B[i, j]))
                        commonValues.Add(B[i, j]);

                    if (j % 2 == 1)
                        sumOddColElemB += B[i, j];
                }
            }
            if (commonValues.Any())
            {
                Console.WriteLine($"Max val = {commonValues.Max()}");
                Console.WriteLine($"Min val = {commonValues.Min()}");
            }
            Console.WriteLine($"Sum of all elements = {sum}");
            Console.WriteLine($"Mult of all el = {mult}");
            Console.WriteLine($"summEvenElemA = {summEvenElemA}");
            Console.WriteLine($"sumOddColElemB = {sumOddColElemB}");
        }

        private static void Task2()
        {
            var rand = new Random();
            var arrM = new int[20];
            for (int i = 0; i < arrM.Length; ++i)
                arrM[i] = rand.Next(arrM.Length);

            var arrN = new int[10];
            for (int i = 0; i < arrN.Length; ++i)
                arrN[i] = rand.Next(arrN.Length);

            var commonValues = new List<int>();
            foreach (var val in arrM)
            {
                if (arrN.Contains<int>(val) && !commonValues.Contains<int>(val))
                    commonValues.Add(val);
            }

            foreach (var val in commonValues)
                Console.WriteLine($"{val} ");
        }

        private static void Task3()
        {
            Console.Write("Enter the number, please: ");
            var inpStr = Console.ReadLine();
            var inpArr = inpStr.ToList<char>();
            inpArr.Reverse();
            var res = new StringBuilder();
            foreach (var val in inpArr)
                res.Append(val);
            if (inpStr == res.ToString())
            {
                Console.WriteLine("The string is a polindrome");
                return;
            }
            Console.WriteLine("The string isn`t a polindrome");
        }

        private static void Task3_2()
        {
            Console.Write("Enter the number, please: ");
            var inpStr = Console.ReadLine();
            var reverse = new string(inpStr.Reverse().ToArray());
            if (inpStr == reverse)
            {
                Console.WriteLine("The string is a polindrome");
                return;
            }
            Console.WriteLine("The string isn`t a polindrome");
        }
    }
}
