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
                        var dictName = _facade.UI.AskUserForInputString("Введите название словаря: ");
                        _dictonaries.CreateNewDictionary(dictName);
                        break;

                    case Act.AddNewWord:
                        var word = _facade.UI.AskUserForInputString("Введите новое слово: ");
                        var translate = _facade.UI.AskUserForInputString("Введите его веревод: ");
                        _dictonaries.AddNewWord(word, translate);
                        break;

                    case Act.AddNewTranslation:
                        word = _facade.UI.AskUserForInputString("Введите слово: ");
                        translate = _facade.UI.AskUserForInputString("Введите его веревод: ");
                        _dictonaries.AddNewTranslation(word, translate);
                        break;

                    case Act.ChangeWord:
                        var oldWord = _facade.UI.AskUserForInputString("Введите старое слово: ");
                        var newWord = _facade.UI.AskUserForInputString("Введите новое слово: ");
                        _dictonaries.ChangeWord(oldWord, newWord);
                        break;

                    case Act.ChangeTranslation:
                        word = _facade.UI.AskUserForInputString("Введите слово: ");
                        var oldTranslation = _facade.UI.AskUserForInputString("Введите перевод, который надо заменить: ");
                        var newTranslation = _facade.UI.AskUserForInputString("Введите перевод на замену: ");
                        _dictonaries.ChangeTranslation(word, oldTranslation, newTranslation);
                        break;

                    case Act.RemoveWord:

                        break;

                    case Act.RemoveTranslation:

                        break;

                    case Act.SearchTranslations:

                        break;

                    case Act.:

                        break;

                    case Act.:

                        break;

                    case Act.WordWasChanged:
                    case Act.TranslateWasAdded:
                    case Act.WordWasAdded:
                    case Act.DictionaryWasCreated:
                    case Act.Done:
                        _facade.UI.ShowMessageToUser("Готово. ");
                        _facade.ShowMenu();
                        break;

                    case Act.ExceptionAction:
                    case Act.DictionaryWasNotCreated:
                    case Act.WordWasNotChanged:
                    case Act.TranslateWasNotAdded:
                    case Act.WordWasNotAdded:
                    case Act.SmthWentWrong:
                        _facade.UI.ShowMessageToUser("В прошлой операции что-то пошло не так. " + message);
                        _facade.ShowMenu();
                        break;

                    default:
                        message = "В программе непредусмотренный переход в меню. " + message;
                        goto case Act.SmthWentWrong;
                }
            }
            catch (Exception ex)
            {
                Log.Error(ex, "");
            }
        }
    }
}
