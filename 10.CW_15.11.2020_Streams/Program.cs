using System;
using System.Collections.Generic;
using System.IO;
using System.Text.RegularExpressions;

namespace _10.CW_15._11._2020_Streams
{
    class Program
    {
        static void Main(string[] args)
        {
            //Task1();
            //Task2();
            //Task3();
            //Task4();
            Task5("10:15 01.05.2020");
            Task5("10:05 01.05.2020");
            Task5("10:05       01.05.2020");
            Task5("10:15 01_05.2020");
            Task5("10:15 01-05-2020");
        }

        private static void Task5(string regexStr)
        {
            var datePattern = @"[0-2]\d:[0-2]\d +[0-3]\d[\.\-_][0-1]\d[\.\-_][0-9]{4}";
            var regex = new Regex(datePattern);
            Console.WriteLine(regex.IsMatch(regexStr) ? "Data received." : "Data is not correct!");
        }

        private static void Task4()
        {
            var filepath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "C__urok_10_1499776005.pdf");
            var outputFilepath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Copy.pdf");
            var stream = new FileStream(filepath, FileMode.Open, FileAccess.Read);
            var streamOut = new FileStream(outputFilepath, FileMode.Create, FileAccess.Write);
            var bytesCount = 0;
            var buf = new byte[1024 * 8];
            while ((bytesCount = stream.Read(buf, 0, buf.Length)) > 0)
            {
                streamOut.Write(buf, 0, bytesCount);
            }
            stream.Close();
            streamOut.Close();
        }

        private static void Task3()
        {
            Console.WriteLine("Enter smth");
            var filepath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "WritedText3.txt");
            if (!StreamClass.TryWriteBinaryFile(filepath))
                Console.WriteLine("Can`t write file");
            if (!StreamClass.TryReadBinaryFile(filepath, out var readedtext))
                Console.WriteLine("Can`t read file");
            Console.WriteLine($"Thats was readed {filepath}");

            foreach (var el in readedtext)
            {
                Console.WriteLine(el);
            }
        }

        private static void Task2()
        {
            Console.WriteLine("Enter smth");
            var text = Console.ReadLine().Split(new char[] { ' ', '.', ',' }, StringSplitOptions.RemoveEmptyEntries);
            var filepath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "WritedText2.txt");
            
            if (!StreamClass.TryWriteAllLines(filepath, text))
                Console.WriteLine("Can`t write file");
            if (!StreamClass.TryReadAllLines(filepath, out var readedtext))
                Console.WriteLine("Can`t read file");
            Console.WriteLine($"Thats was readed {filepath}");
            foreach(var str in readedtext)
                Console.WriteLine(str);
        }

        private static void Task1()
        {
            Console.WriteLine("Enter smth");
            var text = Console.ReadLine();
            var filepath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "WritedText.txt");

            if (!StreamClass.TryWrite(filepath, text))
                Console.WriteLine("Can`t write file");
            if (!StreamClass.TryRead(filepath, out var readedtext))
                Console.WriteLine("Can`t read file");
            Console.WriteLine(readedtext + filepath);
        }
    }
}
