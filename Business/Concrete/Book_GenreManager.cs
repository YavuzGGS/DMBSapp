using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class Book_GenreManager
    {
        private EfBook_GenreDal _bookGenreDal;
        public Book_GenreManager()
        {
            _bookGenreDal = new EfBook_GenreDal();
        }

        public void Add(Book_Genre book_Genre)
        {
            _bookGenreDal.Add(book_Genre);
        }

        public void Delete(Book_Genre book_Genre)
        {
            _bookGenreDal.Delete(book_Genre);
        }

        public List<Book_Genre> GetAll()
        {
            return _bookGenreDal.GetList();
        }

        public Book_Genre GetById(string ISBN)
        {
            return _bookGenreDal.Get(c => c.ISBN == ISBN);
        }

        public void Update(Book_Genre book_Genre)
        {
            _bookGenreDal.Update(book_Genre);
        }
    }
}
