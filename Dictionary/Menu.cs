using System;
using System.Collections.Generic;
using System.Text;

namespace Dictionary
{
    public class Menu
    {
        private IUI _currentIUI;
        private Dict _currentDictionary { get; set; }

        public Menu(IUI uI)
        {
            _currentIUI = uI ?? throw new ArgumentNullException(nameof(uI));
        }

        public void CreateNewDict()
        {
            gg throw new NotImplementedException();
        }

        public void TryAddNewWord(string key, string translatedValue)
        {
            gg throw new NotImplementedException();
        }

        public void TryChangeKeyWord(string key)
        {
            gg throw new NotImplementedException();
        }

        public void TryChangeTranslatedValues(string key, List<string> translatedValues)
        {
            gg throw new NotImplementedException();
        }

        public void TryDeleteKeyWord(string key)
        {
            gg throw new NotImplementedException();
        }

        public void TryDeleteTranslatedValueWord(string key)
        {
            gg throw new NotImplementedException();
        }
    }
}
