

namespace Command
{
    public class MenuOptions
    {
        private ICommand openCommand;
        private ICommand closeCommand;
        private ICommand saveCommand;

        public MenuOptions(ICommand openCommand, ICommand closeCommand, ICommand saveCommand)
        {
            this.openCommand = openCommand;
            this.closeCommand = closeCommand;
            this.saveCommand = saveCommand;
        }

        public void ClickOpen()
        {
            openCommand.Execute();
        }

        public void ClickSave()
        {
            saveCommand.Execute();
        }

        public void ClickClose()
        {
            closeCommand.Execute();
        }
    }
}
