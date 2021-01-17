using System;
using TranslateDictionary;

namespace Dictionary
{
    public class Facade
    {
        private readonly Mediator _mediator;

        public UIConsole UIConsole { get; }

        public Facade(UIConsole uIConsole)
        {
            _mediator = new Mediator(new Saver(), new DictContainer(), this);
            UIConsole = uIConsole ?? throw new ArgumentNullException(nameof(uIConsole));
        }

        public void StartProgram()
        {
            showMenu();
        }
    }
}
