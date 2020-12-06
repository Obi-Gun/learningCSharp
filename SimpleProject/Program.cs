using System;
using System.Runtime.InteropServices;
using static System.Console;
namespace SimpleProject
{
    public class DllImportExample
    {
        [DllImport("SimpleCalc.dll")]
        public static extern int add(int a, int b);
        [DllImport("SimpleCalc.dll")]
        public static extern int sub(int a, int b);
        [DllImport("SimpleCalc.dll")]
        public static extern int mult(int a, int b);
        [DllImport("SimpleCalc.dll")]
        public static extern int div2(int a, int b);
    }
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Write("Enter the first number: ");
                int number1 = int.Parse(ReadLine());
                Write("Enter the second number: ");
                int number2 = int.Parse(ReadLine());
                WriteLine($"\t{number1} + {number2} = { DllImportExample.add(number1, number2)}");
                WriteLine($"\t{number1} - {number2} = { DllImportExample.sub(number1, number2)}");
                WriteLine($"\t{number1} * {number2} = {DllImportExample.mult(number1, number2)}");
                WriteLine($"\t{number1} / {number2} = {DllImportExample.div2(number1, number2)}");
            }
            catch (Exception ex)
            {
                WriteLine(ex.Message);
            }
        }
    }
}