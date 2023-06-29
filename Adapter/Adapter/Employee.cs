

namespace Adapter
{
    public  class Employee
    {
        public int ID { get; set; }
        public string Name { get;set; }


        public string Designation { get; set; }

        public decimal Salary { get; set; }

        public Employee(int _id,string _Name,string _Designation,decimal _salary)
        {
            ID= _id;
            Name= _Name;
            Designation= _Designation;
            Salary= _salary;
        }

    }
}
