using System.Collections;

namespace Patterns.Patterns
{
    public class Book
    {
        public string Name { get; set; }
        public string Author { get; set; }
    }

    public class LibraryIterator : IEnumerator
    {
        private readonly List<Book> _books;

        private int _position = -1;

        public LibraryIterator(List<Book> books)
        {
            _books = books;
        }

        public object Current => _books[_position];

        public bool MoveNext()
        {
            _position++;

            return _position < _books.Count;
        }

        public void Reset()
        {
            _position = -1;
        }
    }

    public class Library : IEnumerable
    {
        private List<Book> _books = new List<Book>();

        public Library()
        {

        }

        public void AddBook(Book book)
        {
            _books.Add(book);
        }

        public IEnumerator GetEnumerator()
        {
            return new LibraryIterator(_books);
        }
    }


}
