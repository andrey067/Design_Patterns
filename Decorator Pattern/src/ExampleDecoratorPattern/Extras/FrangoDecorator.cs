using ExampleDecoratorPattern.Interfaces;

namespace ExampleDecoratorPattern.Extras
{
    //Concrete Decorator
    public class FrangoDecorator : PizzaDecorator
    {
        public FrangoDecorator(IPizza pizza) : base(pizza) { }

        public override string BuscarTipoPizza()
        {
            return base.BuscarTipoPizza() + " com frango";
        }
    }
}