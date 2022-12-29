using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class Book
    {
        [Key]
        public string ISBN { get; set; }
        public string Title { get; set; }
        public string Summary { get; set; }
        public int LanguageID { get; set; }
        public string ImageSource { get; set; }
        public string Author { get; set; }
        
    }
}
