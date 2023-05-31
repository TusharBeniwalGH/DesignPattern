
namespace ChainOfResponsibility
{
    public class HR : EmployeeLeaveHandler
    {

        private readonly int MAX_LEAVES_CAN_APPROVE = 30;

        public override void ApplyLeave(string EmployeeName, int NumberOfDaysLeave)
        {
            if (NumberOfDaysLeave <= MAX_LEAVES_CAN_APPROVE)
            {

                Console.WriteLine($"HR Approved {NumberOfDaysLeave} Days Leave for the Employee {EmployeeName}");
            }

            else
            {
                if (Supervisor != null)
                    Supervisor.ApplyLeave(EmployeeName, NumberOfDaysLeave);
                else
                    Console.WriteLine($"Leave Application Suspended for Employee {EmployeeName}, Please contact HR");
            }
        }
    }
  
}
