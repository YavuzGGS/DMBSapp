using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Dtos
{
    public class BookDetails
    {
        public int ISBN { get; set; }
        public string Title { get; set; }
        public string GenreName  { get; set; }
        public string AuthorName { get; set; }
    }
}
