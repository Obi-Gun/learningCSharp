using Dictionary;
using Serilog;
using System;
using System.Collections.Generic;
using System.Text;

namespace TranslateDictionary
{
    public class Mediator : IMediator
    {
        private Saver _saver;
        private DictContainer _dictonaries;
        private Facade _facade;

        public Mediator(Saver saver, DictContainer dictionaries, Facade facade)
        {
            _saver = saver ?? throw new ArgumentNullException(nameof(saver));
            _saver.SetMediator(this);
            _dictonaries = dictionaries ?? throw new ArgumentNullException(nameof(dictionaries));
            _dictonaries.SetMediator(this);
            _facade = facade ?? throw new ArgumentNullException(nameof(facade));
        }

        public void Notify(object sender, string message, Act action)
        {
            try
            {
                switch (action)
                {
                    case ggg:
                        _saver.DoC();
                        break;
                    case ggg:
                        _dictonaries.DoB();
                        _saver.DoC();
                        break;
                    case ggg:

                        break;
                    case ggg:

                        break;
                    case ggg:

                        break;
                    case ggg:

                        break;
                }
            }
            catch (Exception ex)
            {
                Log.Error(ex, "");
            }
        }
    }
}
