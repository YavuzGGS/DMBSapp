using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess.Abstract;
using Entities.Concrete;
using Core.DataAccess.Concrete.EntityFramework;


namespace DataAccess.Concrete.EntityFramework
{
    public interface EfGenreDal : EfEntityRepositoryBase<Genre, MEFReadsContext>,  IGenreDal
    {
    }
}
