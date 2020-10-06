using System;
using System.Linq;

namespace _1.HW_13._09._2020
{
    class Program
    {
        static void Main(string[] args)
        {
            //task1();
            //task2();
            //task3();
            //task4(3, 7);
            //task5("345678");
        }

        /// <summary>
        /// HW1. Task 5. Course: "C#"
        /// </summary>
        /// <param name="n"></param>
        private static void task5(string n)
        {
            var arr = new string(n.Reverse<char>().ToArray());
            Console.WriteLine(arr);
        }

        /// <summary>
        /// HW1. Task 4. Course: "C#"
        /// </summary>
        private static void task4(int a, int b)
        {
            if (a > b)
            {
                var tmp = a;
                a = b;
                b = tmp;
            }
            for (var i = a; i <= b; ++i)
            {
                for (var j = 0; j < i; ++j)
                    Console.Write(i + " ");

                Console.WriteLine();
            }
        }

        /// <summary>
        /// HW1. Task 3. Course: "C#"
        /// </summary>
        private static void task3()
        {
            Console.Write("Enter the text, please: ");
            var arr = Console.ReadLine().ToCharArray();
            for (var i = 0; i < arr.Length; ++i)
            {
                if (arr[i] >= 'a' && arr[i] <= 'z')
                    arr[i] -= (char)('a' - 'A');
                else if (arr[i] >= 'A' && arr[i] <= 'Z')
                    arr[i] += (char)('a' - 'A');
            }
            Console.WriteLine(new string(arr));
        }

        /// <summary>
        /// HW1. Task 2. Course: "C#"
        /// </summary>
        private static void task2()
        {
            Console.Write("Enter the ticket number, please: ");
            var arr = Console.ReadLine().ToCharArray();
            var arr2 = new byte[arr.Length];
            for (var i = 0; i < arr.Length; ++i)
            {
                if (byte.TryParse(arr[i].ToString(), out arr2[i]))
                    continue;
                Console.WriteLine("The number can not be parsed. Please try again.");
                return;
            }
            int sum1 = 0, sum2 = 0;
            for (var i = 0; i < arr2.Length / 2; ++i)
            {
                sum1 += arr2[i];
                sum2 += arr2[arr2.Length - 1 - i];
            }
            if (sum1 == sum2)
            {
                Console.WriteLine("Congratulations! Happy number!");
                return;
            }
            Console.WriteLine("It is not a happy number.");
        }

        /// <summary>
        /// HW1. Task 1. Course: "C#"
        /// </summary>
        private static void task1()
        {
            Console.WriteLine("Task: Calculate all space simbols which will be entered before first dot simbol.");
            int counter = 0;
            do
            {
                Console.Write("Write something, please: ");
                string inp = Console.ReadLine();
                if (inp.Contains('.'))
                {
                    counter += inp.Split('.')[0].Split(' ').Length - 1;
                    break;
                }
                counter += inp.Split(' ').Length - 1;
            }
            while (true);
            Console.Write($"There are {counter} spaces was inputed");
        }
    }
}
