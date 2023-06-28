using Prototype;

Employee emp1 = new Employee
{
    Name = "Tushar",
    Department = "IT",
    EmpAddress = new Address() { address = "Jodhpur" }
};

Employee emp2=emp1.GetShallowCopy();

emp2.Name = "Kuldeep";

emp2.EmpAddress.address = "Chandigarh";

Employee emp3 = emp2.GetDeepCopy();

emp3.EmpAddress.address = "Jaipur";

Console.WriteLine("Employee 1");

Console.WriteLine("Name: " + emp1.Name + ", Address: "  + emp1.EmpAddress.address + ", Dept: " +emp1.Department);

Console.WriteLine("Employee 2 created through Shallow Copy");

Console.WriteLine("Name: " + emp2.Name + ", Address: " + emp2.EmpAddress.address + ", Dept: " + emp2.Department);

Console.WriteLine("Employee 3 created through Deep Copy");

Console.WriteLine("Name: " + emp3.Name + ", Address: " + emp3.EmpAddress.address + ", Dept: " + emp3.Department);

Console.ReadLine();