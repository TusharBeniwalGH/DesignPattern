using Builder;

Beverage beverage;

BeverageDirector beverageDirector = new BeverageDirector();

TeaBuilder teaBuilder = new TeaBuilder();

beverage = beverageDirector.MakeBeverage(teaBuilder);

if (beverage!=null)
Console.WriteLine(beverage.ShowBeverage());

CoffeeBuilder coffeeBuilder = new CoffeeBuilder();

beverage =beverageDirector.MakeBeverage(coffeeBuilder);

if (beverage != null)
    Console.WriteLine(beverage.ShowBeverage());

Console.ReadKey();

