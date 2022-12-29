using Business.Concrete;
using Entities.Concrete;
using Microsoft.AspNetCore.Mvc;
using UI.Models;

namespace UI.Controllers
{
    public class BookController : Controller
    {
        private BookManager _bookManager;
        private Book_GenreManager _bookGenreManager;
        private GenreManager _genreManager;
        public BookController()
        {
            _bookManager = new BookManager();
            _bookGenreManager = new Book_GenreManager();
            _genreManager = new GenreManager();
        }

        public IActionResult Index(int genre)
        {
            var model = new BookViewModel
            {
                Books = genre>0? _bookManager.GetBooksByGenre(_bookGenreManager.GetByGenreID(genre)) : _bookManager.GetAll()
            };
            return View(model);
        }

        public IActionResult BookDetails(string ISBN)
        {
            var model = new BookViewModel
            {
                Book = _bookManager.GetById(ISBN),
                GenreNames = _genreManager.GetGenresByID(_bookGenreManager.GetBookGenresByISBN(ISBN))
            };
            return View(model);
        }

        public IActionResult AddBook()
        {
            var model = new BookViewModel
            {
                Genres = _genreManager.GetAll()
            };
            return View(model);
        }
        [HttpPost]
        public IActionResult AddBook(Book book, List<int> genres)
        {
            return View();
        }

    }
}
