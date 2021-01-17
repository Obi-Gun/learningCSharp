using System;
using TranslateDictionary;

namespace Dictionary
{
    public class Facade
    {
        private readonly IMediator _mediator;

        public IUI UI { get; }

        public Facade(IUI uI)
        {
            _mediator = new Mediator(new Saver(), new DictContainer(), this);
            UI = uI ?? throw new ArgumentNullException(nameof(uI));
        }

        public void StartProgram()
        {
            //showMenu();
        }

        public void ShowMenu()
        {
            asdf;
            _mediator.Notify();
        }
    }
}
