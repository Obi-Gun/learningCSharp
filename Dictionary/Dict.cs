using Newtonsoft.Json;
using Serilog;
using System;
using System.Collections.Generic;
using System.Text;

namespace TranslateDictionary
{
    [Serializable]
    public class Dict
    {
        [JsonProperty("Words")]
        private readonly Dictionary<string, List<string>> _words = new Dictionary<string, List<string>>();

        [JsonProperty("DictionaryName")]
        public string Name { get; }

        public Dict(string dictName)
        {
            Name = dictName ?? throw new ArgumentNullException(nameof(dictName));
        }

        public bool TryFindWord(string word, out List<string> translations)
        {
            translations = new List<string>();
            try
            {
                if (_words.ContainsKey(word))
                {
                    translations = _words[word];
                    return true;
                }
            }
            catch (Exception ex)
            {
                Log.Error(ex, "Can't ");
            }
            return false;
        }

        public bool TryFindTranslateInConcreteWord(string word, string translation)
        {
            try
            {
                if (!_words.ContainsKey(word)
                    && !_words[word].Contains(translation))
                {
                    return false;
                }
                return true;
            }
            catch (Exception ex)
            {
                Log.Error(ex, "Can't ");
            }
            return false;
        }

        public bool TryFindTranslationInAllWords(string translation, out List<string> words)
        {
            words = new List<string>();
            try
            {
                foreach (var word in _words)
                {
                    foreach (var translate in word.Value)
                    {
                        if (translate == translation)
                        {
                            words.Add(word.Key);
                            break;
                        }
                    }
                }
                if (words.Count > 0)
                {
                    return true;
                }
            }
            catch (Exception ex)
            {
                Log.Error(ex, "Can't ");
            }
            return false;
        }

        public bool TryRemoveWord(string word)
        {
            try
            {
                if (_words.ContainsKey(word))
                {
                    _words[word].Remove(word);
                }
                return true;
            }
            catch (Exception ex)
            {
                Log.Error(ex, "Can't ");
            }
            return false;
        }

        public bool TryAddNewTranslate(string word, string translate)
        {
            try
            {
                if (!_words.ContainsKey(word))
                {
                    _words.Add(word, new List<string> { translate });
                    return true;
                }
                if (!_words[word].Contains(translate))
                {
                    _words[word].Add(translate);
                }
                return true;
            }
            catch (Exception ex)
            {
                Log.Error(ex, "Can't ");
            }
            return false;
        }

        public bool TryRemoveTranslate(string word, string translate)
        {
            try
            {
                if (!_words.ContainsKey(word))
                {
                    return true;
                }
                if (_words[word].Contains(translate))
                {
                    _words[word].Remove(translate);
                }
                return true;
            }
            catch (Exception ex)
            {
                Log.Error(ex, "Can't ");
            }
            return false;
        }

        public bool TryChangeWord(string oldWord, string newWord)
        {
            try
            {
                if (!_words.ContainsKey(oldWord))
                {
                    return false;
                }
                var translations = _words[oldWord];
                _words.Remove(oldWord);
                if (!_words.ContainsKey(newWord))
                {
                    _words.Add(newWord, translations);
                    return true;
                }
                _words[newWord].AddRange(translations);
                return true;
            }
            catch (Exception ex)
            {
                Log.Error(ex, "Can't ");
            }
            return false;
        }
    }
}
