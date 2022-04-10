using ExampleDecoratorPattern.Interfaces;

namespace ExampleDecoratorPattern.Extras
{
    //ConcreteDecorator
    public class CatupiryDecorator : PizzaDecorator
    {
        public CatupiryDecorator(IPizza pizza) : base(pizza)
        { }

        public override string BuscarTipoPizza()
        {
            return base.BuscarTipoPizza() + " com catupiry";
        }
    }
}