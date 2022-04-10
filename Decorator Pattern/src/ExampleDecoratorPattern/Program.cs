using ExampleDecoratorPattern;
using ExampleDecoratorPattern.Extras;
using ExampleDecoratorPattern.Interfaces;

IPizza pizza = new Pizza();
var queijoDecorator = new QueijoDecorator(pizza);
var catupity = new CatupiryDecorator(queijoDecorator);
Console.WriteLine(catupity.BuscarTipoPizza());
