namespace ChainOfResponsibility
{
    internal class Program
    {
        static void Main(string[] args)
        {
            TeamLeader obj1 = new TeamLeader();
            ProjectLeader obj2 = new ProjectLeader();
            HR obj3 = new HR();

            obj1.SetNextSupervisor(obj2);
            obj2.SetNextSupervisor(obj3);

            obj1.ApplyLeave("tushar", 10);

            obj1.ApplyLeave("karan", 20);

            obj1.ApplyLeave("kuldeep", 40);

            obj1.ApplyLeave("raman", 50);

            Console.Read();
        }
    }
}