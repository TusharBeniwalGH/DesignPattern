// See https://aka.ms/new-console-template for more information
using Strategy;

Console.WriteLine("Please enter Travel Type : \n1 for Auto \n2 for Bus \n3 for Train \n4 for Taxi");
int travelType=Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Your select Travel Type", travelType);

TravelContext ctx = new TravelContext();

if (travelType == (int)TravelType.Bus)
{
    ctx.SetTravelStrategy(new BusTravelStrategy());
}
else if (travelType == (int)TravelType.Auto)
{
    ctx.SetTravelStrategy(new AutoTravelStrategy());
}
else if (travelType == (int)TravelType.Train)
{
    ctx.SetTravelStrategy(new TrainTravelStrategy());
}
else if (travelType == (int)TravelType.Taxi)
{
    ctx.SetTravelStrategy(new TaxiTravelStrategy());
}
else
{
    Console.WriteLine("You selected an invalid option");
}

ctx.GoToAirport();

public enum TravelType
{
    Auto=1,
    Bus=2,
    Train=3,
    Taxi=4
}