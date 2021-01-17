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
                    case Act.CreateDictionary:
                        var dictName = _facade.UIConsole.AskUserForInputString("Введите название словаря: ");
                        _dictonaries.CreateNewDictionary(dictName);
                        break;
                    case Act.DictionaryWasNotCreated:

                        break;
                    case Act.DictionaryWasCreated:

                        break;
                    case Act.ExceptionAction:
                        
                        break;
                    case Act.AddNewWord:
                        var word = _facade.UIConsole.AskUserForInputString("Введите новое слово: ");
                        var translate = _facade.UIConsole.AskUserForInputString("Введите его веревод: ");
                        _dictonaries.AddNewWord(word, translate);
                        break;
                    case Act.WordWasAdded:

                        break;
                    case Act.WordWasNotAdded:

                        break;
                    case Act.AddNewTranslation:
                        word = _facade.UIConsole.AskUserForInputString("Введите слово: ");
                        translate = _facade.UIConsole.AskUserForInputString("Введите его веревод: ");
                        _dictonaries.AddNewTranslation(word, translate);
                        break;
                    case Act.TranslateWasAdded:

                        break;
                    case Act.TranslateWasNotAdded:

                        break;
                    case Act.ChangeWord:
                        var oldWord = _facade.UIConsole.AskUserForInputString("Введите старое слово: ");
                        var newWord = _facade.UIConsole.AskUserForInputString("Введите новое слово: ");
                        _dictonaries.ChangeWord(oldWord, newWord);
                        break;
                    case Act.WordWasChanged:

                        break;
                    case Act.WordWasNotChanged:

                        break;
                    case Act.ChangeTranslate:

                        break;
                    case Act.:

                        break;
                    case Act.:

                        break;
                    case Act.:

                        break;
                    case Act.:

                        break;
                    case Act.:

                        break;
                    case Act.:

                        break;
                    case Act.:

                        break;
                    default:

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
