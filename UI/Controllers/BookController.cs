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
        public IActionResult AddBook(Book book, List<int> genres, IFormFile image)
        {
            string path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/images");
            if (!Directory.Exists(path))
                Directory.CreateDirectory(path);
            FileInfo fileInfo = new FileInfo(image.FileName);
            string fileName = image.FileName;
            string fileNameWithPath = Path.Combine(path, fileName);
            using (var stream = new FileStream(fileNameWithPath, FileMode.Create))
            {
                image.CopyTo(stream);
            }
            Book bookToAdd = new Book
            {
                ISBN = book.ISBN,
                Title = book.Title,
                Summary = book.Summary,
                LanguageID = book.LanguageID,
                ImageSource = image.FileName,
                Author = book.Author
            };
            _bookManager.Add(bookToAdd);
            foreach (var genreID in genres)
            {
                Book_Genre book_genre = new Book_Genre
                {
                    BookISBN = book.ISBN,
                    GenreID = genreID
                };
                _bookGenreManager.Add(book_genre);
            }

            return RedirectToAction("Index");
        }

    }
}
