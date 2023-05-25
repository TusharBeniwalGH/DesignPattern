

namespace Command
{
    public class SaveCommand : ICommand
    {
        private Document document;

        public SaveCommand(Document document)
        {
            this.document = document;
        }

        public void Execute()
        {
            document.Save();
        }
    }
    
}
