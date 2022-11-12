using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class AuthorManager
    {
        private EfAuthorDal _authorDal; // Used to access database
        public AuthorManager()
        {
            _authorDal = new EfAuthorDal();
        }

        public void Add(Author author)
        {
            _authorDal.Add(author);
        }

        public void Delete(Author author)
        {
            _authorDal.Delete(author);
        }

        public List<Author> GetAll()
        {
            return _authorDal.GetList();
        }

        public Author GetById(int id) //get author from the DB where id matches the id arg
        {
            return _authorDal.Get(c => c.AuthorID == id);
        }

        public void Update(Author author)
        {
            _authorDal.Update(author);
        }
    }
}
