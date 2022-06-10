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
    public class DistrictRepository : Repository<ENTDistrict>, IDistrictRepository
    {
        private FMContext _fmContext { get { return _context as FMContext; } }
        public DistrictRepository(DbContext fm) : base(fm)
        {
        }
        public List<ENTDistrict> GetByCityID(int cityID)
        {
            return _fmContext.District.Where(a => a.CityID == cityID).ToList();
        }

    }
}
