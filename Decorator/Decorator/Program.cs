using Decorator;

PlainPizza plainPizza = new();

string plainPizzaResult = plainPizza.MakePizza();

Console.WriteLine(plainPizzaResult);

PizzaDecorator chickenPizzaDecorator = new ChickenPizzaDecorator(plainPizza);

string chickenPizzaResult = chickenPizzaDecorator.MakePizza();

Console.WriteLine(chickenPizzaResult);

PizzaDecorator vegPizzaDecorator = new VegPizzaDecorator(plainPizza);

string vegPizzaResult = vegPizzaDecorator.MakePizza();

Console.WriteLine(vegPizzaResult);

Console.Read();