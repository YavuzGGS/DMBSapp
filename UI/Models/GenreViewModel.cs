using Entities.Concrete;
using Microsoft.Extensions.Primitives;

namespace UI.Models
{
    public class GenreViewModel
    {
        public List<Genre> Genres { get; set; }
        public int CurrentGenre { get; set; }
    }
}
