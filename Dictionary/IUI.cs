using System;
using System.Collections.Generic;
using System.Text;

namespace TranslateDictionary
{
    public interface IUI
    {
        int AskUserForInputMenuPoint(string message);

        string AskUserForInputString(string message);

        void ShowMessageToUser(string message);
    }
}
