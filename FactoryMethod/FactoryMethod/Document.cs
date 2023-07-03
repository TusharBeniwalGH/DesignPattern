
namespace FactoryMethod
{
    public abstract class Document
    {
        public abstract void CreatePages();

        private List<Page> _pages = new List<Page>();

        public Document()
        {
            this.CreatePages();
        }
        public List<Page> Pages
        {
            get { return _pages; }
        }
    }
}
