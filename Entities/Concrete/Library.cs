using Core.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class Library : IEntity
    {
        public int LibraryID { get; set; }
        public int UserID { get; set; }
        public int BookID { get; set; }
    }
}
