namespace ChainOfResponsibility
{
   
    public abstract class EmployeeLeaveHandler
    {
       
        protected EmployeeLeaveHandler? Supervisor;

        public void SetNextSupervisor(EmployeeLeaveHandler Supervisor)
        {
            this.Supervisor = Supervisor;
        }

      
        public abstract void ApplyLeave(string EmployeeName, int NumberOfDaysLeave);
    }
}