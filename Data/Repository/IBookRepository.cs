using System.Collections.Generic;
using System.Threading.Tasks;

public interface IBookRepository
{
    IEnumerable<Book> GetAllBooks();
    Book GetBookById(int id);
    void AddBook(Book book);
    void UpdateBook(Book book);
    void DeleteBook(int id);
Task<IEnumerable<Book>> GetAllBooksWithPagination(int pageNumber, int pageSize);

}