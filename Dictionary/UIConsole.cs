using Dictionary;
using System;
using System.Collections.Generic;
using System.Text;

namespace TranslateDictionary
{
    public class UIConsole : IUI
    {
        private const string Separator = "\n\n__________________________________________________________________________";

        static void Main(string[] args)
        {
            var facade = new Facade(new UIConsole());
            facade.StartProgram();
        }

        public int AskUserForInputMenuPoint(string message)
        {
            Console.WriteLine(Separator);
            string input;
            int menuNumber;
            do
            {
                Console.WriteLine();
                Console.WriteLine(message);
                input = Console.ReadLine();
            }
            while (!int.TryParse(input, out menuNumber));
            return menuNumber;
        }

        public string AskUserForInputString(string message)
        {
            Console.WriteLine(Separator);
            Console.WriteLine(message);
            return Console.ReadLine();
        }

        public void ShowMessageToUser(string message)
        {
            Console.WriteLine(Separator);
            Console.WriteLine(message);
        }
    }
}
