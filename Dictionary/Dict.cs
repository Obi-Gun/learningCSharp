using Serilog;
using System;
using System.Collections.Generic;
using System.Text;

namespace TranslateDictionary
{
    public class Dict
    {
        private readonly Dictionary<string, List<string>> _words = new Dictionary<string, List<string>>();

        public string Name { get; set; } = "";

        public Dict()
        {

        }

        public bool TryAddNewWord(string word, string translate)
        {
            try
            {

            }
            catch (Exception ex)
            {
                Log.Error(ex, "");
            }
        }

        public bool TryFindWord(string word)
        {
            try
            {

            }
            catch (Exception ex)
            {
                Log.Error(ex, "");
            }
        }

        public bool TryRemoveWord(string word)
        {
            try
            {

            }
            catch (Exception ex)
            {
                Log.Error(ex, "");
            }
        }

        public bool TryAddNewTranslate(string word, string translate)
        {
            try
            {

            }
            catch (Exception ex)
            {
                Log.Error(ex, "");
            }
        }

        public bool TryFindTranslate(string word, string translate)
        {
            try
            {

            }
            catch (Exception ex)
            {
                Log.Error(ex, "");
            }
        }

        public bool TryFindTranslateInAllWords(string translate, out List<KeyValuePair<string, List<string>>> words)
        {
            try
            {

            }
            catch (Exception ex)
            {
                Log.Error(ex, "");
            }
        }

        public bool TryRemoveTranslate(string word, string translate)
        {
            try
            {

            }
            catch (Exception ex)
            {
                Log.Error(ex, "");
            }
        }

        /*public bool TryAdd(string )
        {

        }

        public bool TryFind(string )
        {

        }

        public bool TryRemove(string )
        {

        }*/

        /*try
            {

            }
            catch (Exception ex)
            {
                Log.Error(ex, "");
            }*/
}
}
