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
        public List<Book_Genre> GetAllByISBN(string ISBN)
        {
            return _bookGenreDal.GetList(c => c.BookISBN == ISBN);
        }
        public List<int> GetBookGenresByISBN(string ISBN)
        {
            List<int> genreIDs = new List<int>();
            List<Book_Genre> book_Genres = GetAll();
            foreach (Book_Genre genre in book_Genres)
                if (ISBN == genre.BookISBN)
                {
                    genreIDs.Add(genre.GenreID);
                }
            return genreIDs;
        }

        public Book_Genre GetByBookID(string ISBN)
        {
            return _bookGenreDal.Get(c => c.BookISBN == ISBN);
        }

        public List<Book_Genre> GetByGenreID(int genreID)
        {
            return _bookGenreDal.GetList(c => c.GenreID == genreID);
        }

        public void Update(Book_Genre book_Genre)
        {
            _bookGenreDal.Update(book_Genre);
        }
    }
}
