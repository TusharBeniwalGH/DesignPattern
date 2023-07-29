namespace ObserverDesignPattern
{
public class Subject :ISubject
{
    private readonly List<IObserver> observers=new();

    private string? ProductName {get;set;}

    private int? ProductPrice {get;set;}

    private string? Availability {get;set;}

    public Subject(string? ProductName, int? ProductPrice,string? Availability)
    {
        this.ProductName = ProductName;
        this.ProductPrice = ProductPrice;
        this.Availability = Availability;

        
    }

    public string? GetAvailability()
    {
        return this.Availability;
    }

    public void SetAvailability(string? availability)
    {
        this.Availability=availability;
        Console.WriteLine("Availability changed from Out of Scope to Available");
        NotifyObservers();
    }
public void NotifyObservers()
    {
       Console.WriteLine("Product Name :" + ProductName + ", product Price : " 
       + ProductPrice + "is Now available. So, notifying all Registered users");

       Console.WriteLine();
       foreach(IObserver observer in observers)
       {
        observer.Update(Availability ?? null);
       }
    }

    public void RegisterObserver(IObserver observer)
    {
        Console.WriteLine("Observer Added : " + ((Observer)observer).UserName);
        observers.Add(observer);
    }

    public void RemoveObserver(IObserver observer)
    {
        Console.WriteLine("Observer Removed : " + ((Observer)observer).UserName);
        observers.Remove(observer);

        
    }
}
}