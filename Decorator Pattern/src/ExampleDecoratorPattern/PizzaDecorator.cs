using ExampleDecoratorPattern.Interfaces;

namespace ExampleDecoratorPattern
{
    public class PizzaDecorator : IPizza
    {
        //Base Decorator
        private readonly IPizza _pizza;

        public PizzaDecorator(IPizza pizza)
        {
            _pizza = pizza;
        }

        public virtual string BuscarTipoPizza()
        {
            return _pizza.BuscarTipoPizza();
        }
    }
}