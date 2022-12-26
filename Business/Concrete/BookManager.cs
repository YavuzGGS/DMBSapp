using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class BookManager
    {
        private EfBookDal _bookDal; 
        public BookManager()
        {
            _bookDal = new EfBookDal();
        }

        public void Add(Book book)
        {
            _bookDal.Add(book);
        }

        public void Delete(Book book)
        {
            _bookDal.Delete(book);
        }

        public List<Book> GetAll()
        {
            return _bookDal.GetList();
        }

        public List<Book> GetBooksByGenre( List<Book_Genre> book_Genres)
        {
            List<Book> books = new List<Book>();
            foreach (var genre in book_Genres)
            {
                books.Add(_bookDal.Get(book => book.ISBN == genre.BookISBN));
            }
            return books;
        }

        public Book GetById(string ISBN)
        {
            return _bookDal.Get(c => c.ISBN == ISBN);
        }

        public void Update(Book book)
        {
            _bookDal.Update(book);
        }
    }
}
