using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    
    public class Library
    {
        [Key]
        public int EntryID { get; set; }
        public int UserID { get; set; }
        public string BookID { get; set; }
    }
}
