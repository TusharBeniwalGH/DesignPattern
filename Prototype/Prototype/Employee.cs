

namespace Prototype
{
    public class Employee
    {
        public string Name { get; set; }

        public string Department { get; set; }

        public Address EmpAddress { get; set; }

        public Employee GetShallowCopy()
        {
            return (Employee)this.MemberwiseClone();
        }

        public Employee GetDeepCopy()
        {
            Employee employee = (Employee)this.MemberwiseClone();

            employee.EmpAddress = EmpAddress.GetClone();
            return employee;
        }
    }

    public class Address
    {
        public string address { get; set; }

        public Address GetClone()
        {
            return (Address)this.MemberwiseClone();
        }
    }
}
