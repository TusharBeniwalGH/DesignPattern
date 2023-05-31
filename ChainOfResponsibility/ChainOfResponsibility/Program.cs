using ChainOfResponseAbility;

Approver larry = new Director();

Approver sam = new VicePresident();

Approver tammy = new President();

larry.SetSucessor(sam);
sam.SetSucessor(tammy);

Purchase p = new Purchase(2034, 350.00, "Supplies");
larry.ProcessRequest(p);

p = new Purchase(2035, 12590.10, "Project X");
larry.ProcessRequest(p);

p = new Purchase(2036, 122100.00, "Project Y");
larry.ProcessRequest(p);

Console.ReadKey();
