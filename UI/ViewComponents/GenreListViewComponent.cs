using Business.Concrete;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ViewComponents;
using UI.Models;

namespace UI.ViewComponents
{
    public class GenreListViewComponent : ViewComponent
    {
        private GenreManager _genreManager;
        public GenreListViewComponent()
        {
            _genreManager = new GenreManager();
        }
        public ViewViewComponentResult Invoke()
        {
            var model = new GenreViewModel
            {
                Genres = _genreManager.GetAll()
            };
            return View(model);

        }
    }
}
