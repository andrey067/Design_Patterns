
using ExampleDecoratorPattern.Interfaces;

namespace ExampleDecoratorPattern.Extras
{
    //ConcreteDecorator 
    public class QueijoDecorator : PizzaDecorator
    {
        public QueijoDecorator(IPizza pizaa) : base(pizaa)
        { }

        public override string BuscarTipoPizza()
        {
            return base.BuscarTipoPizza() + " com queijo";
        }
    }
}