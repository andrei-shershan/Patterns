using Patterns.Patterns;

namespace Patterns.UseCases
{
    public class IteratorCase : IUseCase
    {
        public void Run()
        {
            Console.WriteLine(nameof(IteratorCase));
            
            var library = new Library();
            library.AddBook(new Book() { Name = "Book1", Author = "Author1" });
            library.AddBook(new Book() { Name = "Book2", Author = "Author2" });
            library.AddBook(new Book() { Name = "Book3", Author = "Author3" });

            foreach (Book book in library)
            {
                Console.WriteLine($"Book: {book.Name}, Author: {book.Author}");
            }
        }
    }
}
