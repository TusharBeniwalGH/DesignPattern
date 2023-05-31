
namespace ChainOfResponsibility
{
    internal class ProjectLeader : EmployeeLeaveHandler
    {

        private readonly int MAX_LEAVES_CAN_APPROVE = 20;

        public override void ApplyLeave(string EmployeeName, int NumberOfDaysLeave)
        {
            if (NumberOfDaysLeave <= MAX_LEAVES_CAN_APPROVE)
            {

                Console.WriteLine($"Project Leader Approved {NumberOfDaysLeave} Days Leave for the Employee {EmployeeName}");
            }

            else
            {
                if (Supervisor != null)
                    Supervisor.ApplyLeave(EmployeeName, NumberOfDaysLeave);
                else
                    throw new Exception("Null Reference Exception");
            }
        }
    }
    
}
