using Business.Concrete;
using Microsoft.AspNetCore.Mvc;
using UI.Models;

namespace UI.Controllers
{
    public class BookController : Controller
    {
        private BookManager _bookManager;
        public BookController()
        {
            _bookManager = new BookManager();
        }

        public IActionResult Index()
        {
            var model = new BookViewModel
            {
                Books = _bookManager.GetAll()
            };
            return View(model);
        }
    }
}
