

namespace Adapter
{
    public class ThirdPartyBillingSystem
    {
        public void ProcessSalary(List<Employee> listemployee)
        {
            foreach(Employee emp in listemployee)
            {
                Console.WriteLine("Rs. " + emp.Salary + "Salary credited to " + emp.Name + " Account");
            }
        }
    }
}
