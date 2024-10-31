using LibraryManagementApp.Exceptions;
using LibraryManagementApp.Models;
using LibraryManagementApp.Services.Abstraction;

namespace LibraryManagementApp.Services.Concretes
{
    internal class BookServices : IBookService
    {
        List<Book> books = new();
        void IBookService.CreateBook(Book book)
        {
            books.Add(book);
        }

        void IBookService.DeleteBook(int id)
        {
            for (int i = 0; i < books.Count; i++)
            {
                if (id == books[i].Id)
                {
                    books.Remove(books[i]);
                }

            }
            throw new CustomLibraryItemException($"Daxilin edilən Id-ə({id}) sahib kitab catalogda yer almir");

        }

        public List<Book> GetAllBook()
        {
            return books;
        }

        Book IBookService.GetBookById(int id)
        {
            Book? book = books.Find(x => x.Id == id);
            return book;
        }

        public Book GetBookByTitle(string title)
        {
            for (int i = 0; i < books.Count; i++)
            {
                if (books[i].Title == title)
                {
                    return books[i];
                }
            }
            return null;
        }
    }
}
