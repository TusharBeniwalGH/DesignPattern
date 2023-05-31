
namespace ChainOfResponsibility
{
    public abstract class EmployeeLeaveHandler
    {
        protected EmployeeLeaveHandler? Supervisior;

        public void SetNextSupervisor(EmployeeLeaveHandler handler)
        {
            Supervisior = handler;
        }

        public abstract void ApplyLeave(string EmployeeName, int NumberOfDaysLeave);
    }
}
