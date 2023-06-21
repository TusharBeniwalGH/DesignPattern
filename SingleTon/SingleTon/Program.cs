

Parallel.Invoke(
    () => { SingleTon.SingleTon ton = SingleTon.SingleTon.GetInstance(); ton.PrintDetails("From Teacher"); });


Parallel.Invoke(
    () => { SingleTon.SingleTon ton = SingleTon.SingleTon.GetInstance(); ton.PrintDetails("From Student"); });

Console.ReadLine();