using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class Book_Genre
    {
        [Key]
        public int BookGenreID { get; set; }
        public string BookISBN { get; set; }
        public int GenreID { get; set; }
    }
}
