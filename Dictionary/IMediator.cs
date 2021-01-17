using Dictionary;
using System;
using System.Collections.Generic;
using System.Text;

namespace TranslateDictionary
{
    public interface IMediator
    {
        void Notify(object sender, string message, Act action);
    }
}
