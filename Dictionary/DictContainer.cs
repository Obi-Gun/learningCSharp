using Dictionary;
using Serilog;
using System;
using System.Collections.Generic;
using System.Text;

namespace TranslateDictionary
{
    public class DictContainer : BaseComponent
    {
        private Dictionary<string, Dict> _dictionaries = new Dictionary<string, Dict>();

        public void AddNewDictionary(string dictName)
        {
            try
            {

                _mediator.Notify(this, Act.);
            }
            catch (Exception ex)
            {
                Log.Error(ex, "");
            }
            _mediator.Notify(this, Act.);
        }

        public bool TryFindDictionaryByName(string dictName)
        {
            try
            {

                return true;
            }
            catch (Exception ex)
            {
                Log.Error(ex, "");
            }
            return false;
        }

        public void Remove(string )
        {
            try
            {

                _mediator.Notify(this, Act.);
            }
            catch (Exception ex)
            {
                Log.Error(ex, "");
            }
            _mediator.Notify(this, Act.);
        }
    }
}
