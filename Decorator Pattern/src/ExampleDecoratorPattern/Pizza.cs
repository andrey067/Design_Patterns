using ExampleDecoratorPattern.Interfaces;

namespace ExampleDecoratorPattern
{
    public class Pizza : IPizza
    {
        public string BuscarTipoPizza()
        {
            return "Esta é uma pizza normal";
        }
    }
}