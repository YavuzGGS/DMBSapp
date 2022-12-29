using Entities.Concrete;

namespace UI.Models
{
    public class BookViewModel
    {
        public List<Book> Books { get; set; }
        public Book Book { get; set; }
        public List<string> GenreNames { get; set; }
        public List<Genre> Genres { get; set; }
    }
}
