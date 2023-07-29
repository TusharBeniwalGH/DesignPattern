using ObserverDesignPattern;

Subject RedMI=new("Red MI Mobile",1000,"Out Of Stock");

Observer user1=new("Tushar");
user1.AddSubscriber(RedMI);

Observer user2=new("Karan");
user2.AddSubscriber(RedMI);

Observer user3=new("Kuldeep");

user3.AddSubscriber(RedMI);

Console.WriteLine("Red Mi Mobile current state: " + RedMI.GetAvailability());

Console.WriteLine();

user3.RemoveSubscriber(RedMI);

RedMI.SetAvailability("Available");

Console.Read();