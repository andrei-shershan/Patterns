namespace Patterns.Patterns
{
    namespace State
    {
        public class Document
        {
            private IDocumentState _state;

            public Document()
            {
                _state = new NewDocument();
            }

            public void Create()
            {
                _state.Create(this);
            }

            public void Save()
            {
                _state.Save(this);
            }

            public void Publish()
            {
                _state.Publish(this);
            }

            public void ChangeState(IDocumentState state)
            {
                _state = state;
            }
        }

        public interface IDocumentState
        {
            void Create(Document document);
            void Save(Document document);
            void Publish(Document document);
        }

        public class NewDocument : IDocumentState
        {
            public void Create(Document document)
            {
                Console.WriteLine("Nothing to save");
            }

            public void Save(Document document)
            {
                Console.WriteLine("Saving document...");
                document.ChangeState(new DraftDocument());
            }

            public void Publish(Document document)
            {
                Console.WriteLine("Publishing document");
                document.ChangeState(new PublishedDocument());
            }
        }

        public class DraftDocument : IDocumentState
        {
            public void Create(Document document)
            {
                Console.WriteLine("All data will be lost!");
                document.ChangeState(new NewDocument());
            }

            public void Save(Document document)
            {
                Console.WriteLine("Saving draft...");
            }

            public void Publish(Document document)
            {
                Console.WriteLine("Publishing document...");
                document.ChangeState(new PublishedDocument());
            }
        }

        public class PublishedDocument : IDocumentState
        {
            public void Create(Document document)
            {
                Console.WriteLine("Document is already published! You can't create new one");
            }

            public void Save(Document document)
            {
                Console.WriteLine("Document is already published! You can't edit it!");
            }

            public void Publish(Document document)
            {
                Console.WriteLine("Document is already published!");
            }
        }
    }
}
