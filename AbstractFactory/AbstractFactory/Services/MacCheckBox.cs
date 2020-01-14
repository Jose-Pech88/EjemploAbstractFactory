using AbstractFactory.Services.Interfaces;

namespace AbstractFactory.Services
{
    class MacCheckBox : ICheckBox
    {
        public string CreateCheckBox()
        {
            return "{Resultado CreateCheckBox WIN}";
        }
    }
}
