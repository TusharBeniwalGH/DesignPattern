
namespace Command
{
    public class OpenCommand : ICommand
    {
        private Document document;

        public OpenCommand(Document document)
        {
            this.document = document;
        }

        public void Execute()
        {
            document.Open();
        }
    }
}
