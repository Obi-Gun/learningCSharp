using System;
using System.Collections.Generic;
using System.Text;

namespace TranslateDictionary
{
    public class Saver : BaseComponent
    {
        public void SaveCurrentDictToTxt()
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

        public void SaveCurrentDictToJson()
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
