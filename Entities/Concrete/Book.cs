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
        [Required]
        public string ISBN { get; set; }
        [Required]
        public string Title { get; set; }
        [Required]
        public string Summary { get; set; }
        [Required]
        public int LanguageID { get; set; }
        [Required]
        public string ImageSource { get; set; }
        [Required]
        public string Author { get; set; }
        
    }
}
