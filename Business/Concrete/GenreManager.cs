using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class GenreManager
    {
        private EfGenreDal _genreDal;
        public GenreManager()
        {
            _genreDal = new EfGenreDal();
        }

        public void Add(Genre genre)
        {
            _genreDal.Add(genre);
        }

        public void Delete(Genre genre)
        {
            _genreDal.Delete(genre);
        }

        public List<Genre> GetAll()
        {
            return _genreDal.GetList();
        }

        public Genre GetById(int id)
        {
            return _genreDal.Get(c => c.GenreID == id);
        }

        public void Update(Genre genre)
        {
            _genreDal.Update(genre);
        }

        public List<string> GetGenresByID(List<int> ids)
        {
            List<string> genres = new List<string>();
            foreach (int id in ids)
            {
                genres.Add(GetById(id).GenreName+" ");
            }

            return genres;
        }
    }
}
