using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RESTService
{
    public interface IBookRepository
    {
        List<Book> GetAllBooks();

        Book GetBookById(int id);

        Book AddNewBook(Book newBook);

        bool DeleteBook(int idDeletedBook);

        bool UpdateBook(Book updatedBook);
    }
}
