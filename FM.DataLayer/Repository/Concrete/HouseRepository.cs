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
    public class HouseRepository : Repository<ENTHouse>, IHouseRepository
    {
        private FMContext _fmContext { get { return _context as FMContext; } }
        public HouseRepository(DbContext fm) : base(fm)
        {
        }

        public List<ENTHouse> GetByUserID(int id)
        {
            return _fmContext.House.Where(m => m.UserID == id).ToList();
        }

    }
}
