using Core.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class Genre : IEntity
    {
        public int GenreID { get; set; }
        public string GenreName { get; set; }
    }
}
