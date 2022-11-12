using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class LanguageManager
    {
        private EfLanguageDal _languageDal;
        public LanguageManager()
        {
            _languageDal = new EfLanguageDal();
        }

        public void Add(Language language)
        {
            _languageDal.Add(language);
        }

        public void Delete(Language language)
        {
            _languageDal.Delete(language);
        }

        public List<Language> GetAll()
        {
            return _languageDal.GetList();
        }

        public Language GetById(int id)
        {
            return _languageDal.Get(c => c.LanguageID == id);
        }

        public void Update(Language language)
        {
            _languageDal.Update(language);
        }
    }
}
