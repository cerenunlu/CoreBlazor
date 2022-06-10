using FM.DataLayer.Entities;
using FM.DataLayer.Repository.Abstract;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FM.DataLayer.Repository.Concrete
{
    public class CityRepository : Repository<ENTCity>, ICityRepository
    {
        private FMContext _fmContext { get { return _context as FMContext; } }
        public CityRepository(DbContext fm) : base(fm)
        {
        }
    }
}
