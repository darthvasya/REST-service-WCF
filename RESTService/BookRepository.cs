using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RESTService
{
    public class BookRepository : IBookRepository
    {
        private List<Book> books = new List<Book>();
        private int counter = 1;

        public BookRepository()
        {
            AddNewBook(new Book { Title = "First", ISBN = "123456" });
            AddNewBook(new Book { Title = "second", ISBN = "1456778"});
            AddNewBook(new Book { Title = "Third", ISBN = "987654"});
        }


        //CRUD operations

        //1.CREAT
        public Book AddNewBook(Book newBook)
        {
            if (newBook == null)
                throw new ArgumentException("newBook");
            newBook.BookId = counter++;
            books.Add(newBook);
            return newBook;
        }
        //2.RETRIEVE /ALL
        public List<Book> GetAllBooks()
        {
            return books;
        }

        //2.RETRIEVE /ALL
        public Book GetBookById(int id)
        {
            return books.Find(p => p.BookId == id);
        }

        //3.UPDATE
        public bool UpdateBook(Book updatedBook)
        {
            if (updatedBook == null)
                throw new ArgumentNullException("updatedBook");
            int idx = books.FindIndex(p => p.BookId == updatedBook.BookId);
            if (idx == -1)
                return false;
            books.RemoveAt(idx);
            books.Add(updatedBook);
            return true;
        }

        //4.DELETE
        public bool DeleteBook(int idDeletedBook)
        {
            int idx = books.FindIndex(p => p.BookId == idDeletedBook);
            if (idx == -1)
                return false;
            books.RemoveAll(p => p.BookId == idDeletedBook);
            return true;
        }




        




    }
}