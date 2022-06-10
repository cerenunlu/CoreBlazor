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
    public class SampleCriteriaRepository : Repository<ENTSampleCriteria>, ISampleCriteriaRepository
    {
        private FMContext _fmContext { get { return _context as FMContext; } }
        public SampleCriteriaRepository(DbContext fm) : base(fm)
        {
        }
        public ENTSampleCriteria FindOrAdd(ENTSampleCriteria sampleCriteria)
        {
            var criteria = _fmContext.SampleCriteria.Where(a => a.Age == sampleCriteria.Age && a.PreferredGender == sampleCriteria.PreferredGender
             && a.Cleanliness == sampleCriteria.Cleanliness && a.PartyHabit == sampleCriteria.PartyHabit && a.Friendship == sampleCriteria.Friendship).FirstOrDefault();
            if (criteria == null)
            {
                return null;
            }
            else
            {
                return criteria;
            }
        }

        public ENTSampleCriteria GetCriteriaByID(int id)
        {
            var criteria = _fmContext.SampleCriteria.Where(a => a.ID == id).FirstOrDefault();
            if (criteria == null)
            {
                return null;
            }
            else
            {
                return criteria;
            }
        }
    }
}
