using Dictionary;
using Newtonsoft.Json;
using Serilog;
using System;
using System.Collections.Generic;
using System.Text;

namespace TranslateDictionary
{
    [Serializable]
    public class DictContainer : BaseComponent
    {
        [JsonProperty("Разные словари")]
        private Dictionary<string, Dict> _dictionaries = new Dictionary<string, Dict>();
        private Dict _currentDict = null;

        public void SetCurrentDict(string dictName)
        {
            try
            {
                if (_dictionaries.ContainsKey(dictName))
                {
                    _currentDict = _dictionaries[dictName];
                    _mediator.Notify(this, $"Dict {dictName} was set as default", Act.DictionatyWasSetByCurrentDict);
                }
                _mediator.Notify(this, $"Dict {dictName} was not set as default", Act.DictionatyWasNotBeSettedByCurrentDict);
            }
            catch (Exception ex)
            {
                Log.Error(ex, "");
                _mediator.Notify(this, ex.Message, Act.ExceptionAction);
            }
        }

        public void CreateNewDictionary(string dictName)
        {
            try
            {
                if (_dictionaries.ContainsKey(dictName))
                {
                    _mediator.Notify(this, $"You already have dictionary with name {dictName}. ", Act.DictionaryWasNotCreated);
                }
                _dictionaries.Add(dictName, new Dict(dictName));
                _mediator.Notify(this, $"Now you have dictionary with name {dictName}. ", Act.DictionaryWasCreated);
            }
            catch (Exception ex)
            {
                Log.Error(ex, "");
                _mediator.Notify(this, ex.Message, Act.ExceptionAction);
            }
        }

        public bool TryGetDictionarysNames(out Dictionary<string, Dict>.KeyCollection dictName)
        {
            dictName = null;
            if (_dictionaries.Count == 0)
            {
                return false;
            }
            dictName = _dictionaries.Keys;
            return true;
        }

        public void AddNewWord(string word, string translate)
        {
            if (_currentDict.TryAddNewTranslate(word, translate))
            {
                _mediator.Notify(this, $"Word {word} was added. ", Act.WordWasAdded);
            }
            _mediator.Notify(this, $"Word {word} was not added. ", Act.WordWasNotAdded);
        }

        public bool FindWord(string word, out List<string> translations)
        {
            if (_currentDict.TryFindWord(word, out translations))
            {
                return true;
            }
            _mediator.Notify(this, $"Word {word} was not found. ", Act.WordWasNotFound);
            return false;
        }

        public void RemoveWord(string word)
        {
            if (_currentDict.TryRemoveWord(word))
            {
                _mediator.Notify(this, $"Word {word} was removed. ", Act.WordWasRemoved);
            }
            _mediator.Notify(this, $"Word {word} was not removed. ", Act.WordWasNotFound);
        }

        public void AddNewTranslation(string word, string translate)
        {
            if (_currentDict.TryAddNewTranslate(word, translate))
            {
                _mediator.Notify(this, $"Translate {translate} was added. ", Act.TranslateWasAdded);
            }
            _mediator.Notify(this, $"Translate {translate} was not added. ", Act.TranslateWasNotAdded);
        }

        public void FindTranslation(string word, string translate)
        {
            if (_currentDict.TryFindTranslateInConcreteWord(word, translate))
            {
                _mediator.Notify(this, $"Translate {translate} was found. ", Act.TranslateWasFound);
            }
            _mediator.Notify(this, $"Translate {translate} was not found. ", Act.TranslateWasNotFound);
        }

        public bool TryFindTranslationInAllWords(string translate, out List<string> words)
        {
            if (_currentDict.TryFindTranslationInAllWords(translate, out words))
            {
                return true;
                //_mediator.Notify(this, $"Translate {translate} was found. ", Act.TranslationsWereFound);
            }
            _mediator.Notify(this, $"Translate {translate} was not found. ", Act.TranslationsWereNotFound);
            return false;
        }

        public void RemoveTranslation(string word, string translate)
        {
            if (_currentDict.TryRemoveTranslate(word, translate))
            {
                _mediator.Notify(this, $"Translate {translate} was removed. ", Act.TranslateWasRemoved);
            }
            _mediator.Notify(this, $"Translate {translate} was not removed. ", Act.TranslateWasNotRemoved);
        }

        public void ChangeWord(string oldWord, string newWord)
        {
            if (_currentDict.TryChangeWord(oldWord, newWord))
            {
                _mediator.Notify(this, $"Word {oldWord} was changed. ", Act.WordWasChanged);
            }
            _mediator.Notify(this, $"Word {oldWord} was not changed. ", Act.WordWasNotChanged);
        }

        public void ChangeTranslation(string word, string oldTranslation, string newTranslation)
        {
            _currentDict.TryRemoveTranslate(word, oldTranslation);
            AddNewTranslation(word, newTranslation);
        }
    }
}
