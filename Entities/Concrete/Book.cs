using Core.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class Book : IEntity
    {
        public int ISBN { get; set; }
        public string Title { get; set; }
        public string Summary { get; set; }
        public string LanguageID { get; set; }
        
    }
}
