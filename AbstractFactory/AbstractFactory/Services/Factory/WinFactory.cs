using AbstractFactory.Services.Factory.Interfaces;
using AbstractFactory.Services.Interfaces;

namespace AbstractFactory.Services.Factory
{
    public class WinFactory : IGUIFactory
    {
        public IButton CreateButton()
        {
            return new WinButton();
        }

        public ICheckBox CreateCheckBox()
        {
            return new WinCheckBox();
        }
    }
}
