using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities.Concrete;
using Core.DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.EntityFramework.Contexts;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfLanguageDal : EfEntityRepositoryBase<Language, MEFReadsContext>
    {
    }
}
