using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class LibraryManager
    {
        private EfLibraryDal _libraryDal; 
        public LibraryManager()
        {
            _libraryDal = new EfLibraryDal();
        }

        public void Add(Library library)
        {
            _libraryDal.Add(library);
        }

        public void Delete(Library library)
        {
            _libraryDal.Delete(library);
        }

        public List<Library> GetAll(int id)
        {
            return _libraryDal.GetList(c => c.UserID == id);
        }

        public void Update(Library library)
        {
            _libraryDal.Update(library);
        }
    }
}
