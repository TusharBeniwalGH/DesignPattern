
namespace ChainOfResponsibility
{
    public class ProjectLeader : EmployeeLeaveHandler
    {
        private readonly int MAX_LEAVES_CAN_APPROVE = 20;
        public override void ApplyLeave(string EmployeeName, int NumberOfDaysLeave)
        {
            if (NumberOfDaysLeave <= MAX_LEAVES_CAN_APPROVE)
            {
                Console.WriteLine($"TeamLeader Approved {NumberOfDaysLeave} Days Leave for the Employee {EmployeeName}");
            }
            else
            {
                if (Supervisior != null)
                    Supervisior.ApplyLeave(EmployeeName, NumberOfDaysLeave);
                else
                    throw new Exception("Null Reference Exception");
            }
        }
    
    }
}
