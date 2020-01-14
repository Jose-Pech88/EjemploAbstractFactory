using AbstractFactory.Services.Factory.Interfaces;
using AbstractFactory.Services.Interfaces;

namespace AbstractFactory.Services.Factory
{
    class MacFactory : IGUIFactory
    {
        public IButton CreateButton()
        {
            return new MacButton();
        }

        public ICheckBox CreateCheckBox()
        {
            return new MacCheckBox();
        }
    }
}
