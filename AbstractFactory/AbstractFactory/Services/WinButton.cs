using AbstractFactory.Services.Interfaces;

namespace AbstractFactory.Services
{
    public class WinButton : IButton
    {
        public string CreateButton()
        {
            return "{Resultado CreateButton WIN}";
        }
    }
}
