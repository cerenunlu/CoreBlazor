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
    public class SampleFacilityRepository : Repository<ENTSampleFacility>, ISampleFacilityRepository
    {
        private FMContext _fmContext { get { return _context as FMContext; } }
        public SampleFacilityRepository(DbContext fm) : base(fm)
        {
        }
        public ENTSampleFacility FindOrAdd(ENTSampleFacility sampleFacility)
        {
            var facility = _fmContext.SampleFacility.Where(a => a.CableTv == sampleFacility.CableTv
            && a.Internet == sampleFacility.Internet
            && a.WashingMachine == sampleFacility.WashingMachine
            && a.Dishwasher == sampleFacility.Dishwasher
            && a.AirConditioner == sampleFacility.AirConditioner
            && a.PetsAllowed == sampleFacility.PetsAllowed
            && a.Smoking == sampleFacility.Smoking).FirstOrDefault();
           

            if (facility == null)
            {
                return null;
            }
            else
            {
                return facility;
            }
        }
    }
}
