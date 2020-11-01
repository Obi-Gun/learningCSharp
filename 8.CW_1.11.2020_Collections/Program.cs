using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace _8.CW_1._11._2020_Collections
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.Unicode;
            //Task1();
            //ValueTypePerfTest();
            Task2();
            //Task3();
            //Task4();
        }

        private static void Task4()
        {
            var rand = new Random();
            Console.OutputEncoding = Encoding.Unicode;
            var list1 = new List<int>();
            for (int i = 0; i < 10; ++i)
                list1.Add(rand.Next(0, 20));
            foreach (var val in list1)
                Console.Write(val + " ");

            Console.WriteLine();
            var list2 = new List<int>();
            for (int i = 0; i < 10; ++i)
                list2.Add(rand.Next(0, 20));
            foreach (var val in list2)
                Console.Write(val + " ");

            var hashSet = new HashSet<int>();
            foreach (var val in list1)
                hashSet.Add(val);

            foreach (var val in list2)
            {
                if (hashSet.Contains(val))
                {
                    hashSet.Remove(val);
                    Console.WriteLine(val);
                }
                else
                {
                    hashSet.Add(val);
                }
            }

            foreach (var val in hashSet)
                Console.Write(val + " ");

        }

        private static void Task3()
        {
            var list1 = new List<int>();
            var list = new List<int>();
            for (var i = 0; i < 10; ++i)
            {
                list1.Add(i * 2);
                list.Add(i);
            }

            var hashSet = new HashSet<int>(list1);
            foreach (var val in list)
                hashSet.Add(val);

            foreach (var val in hashSet)
                Console.WriteLine(val);
        }

        private static void Task2()
        {
            Program prog = new Program();
            for (int i = 0; i < 4; ++i)
            {
                new Thread(prog.operation1).Start();
                new Thread(prog.operation2).Start();
            }
        }

        void operation1()
        {
            const int COUNT = 100000;
            var list = new List<int>();
            using (new OperationTimer("List"))
            {
                for (int n = 0; n < COUNT; n++)
                    list.Add(n);

                for (int n = 0; n < COUNT; n++)
                    list.Remove(0);

                list = null;
            }
        }

        void operation2()
        {
            const int COUNT = 100000;
            var linkedList = new LinkedList<int>();
            using (new OperationTimer("LinkedList"))
            {
                for (int n = 0; n < COUNT; n++)
                    linkedList.AddLast(n);

                for (int n = 0; n < COUNT; n++)
                    linkedList.RemoveFirst();

                linkedList = null;
            }
        }

        private static void ValueTypePerfTest()
        {
            const int COUNT = 10000000;
            for (int i = 0; i < 5; ++i)
            {
                using (new OperationTimer("List"))
                {
                    List<int> list = new List<int>(COUNT);
                    for (int n = 0; n < COUNT; n++)
                    {
                        list.Add(n);
                        int x = list[n];
                    }
                    list = null;
                }
                using (new OperationTimer("ArrayList"))
                {
                    ArrayList array = new ArrayList();
                    for (int n = 0; n < COUNT; n++)
                    {
                        array.Add(n);
                        int x = (int)array[n];
                    }
                    array = null;
                }
            }
        }

        private void Task1()
        {
            Console.OutputEncoding = Encoding.Unicode;
            var text = "Вот дом, Который построил Джек. А это пшеница, Которая в темном чулане " +
                "хранится В доме, Который построил Джек. А это веселая птица-синица, Которая " +
                "часто ворует пшеницу, Которая в темном чулане хранится В доме, Который " +
                "построил Джек.";
            var dict = new Dictionary<string, int>();
            var words = text.Split(new char[] { ' ', '.', ',' });
            var wordsCounter = 0;
            foreach (var word in words)
            {
                if (word == string.Empty || word == " ")
                    continue;

                if (dict.ContainsKey(word))
                    ++dict[word];

                else
                    dict.Add(word, 1);

                ++wordsCounter;
            }

            foreach (var word in dict)
                Console.WriteLine($"{word.Key} = {word.Value}");

            Console.WriteLine($"Всего слов {wordsCounter}, из них уникальных {dict.Count}");
        }
    }
}
