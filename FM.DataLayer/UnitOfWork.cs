using FM.DataLayer.Repository.Abstract;
using FM.DataLayer.Repository.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FM.DataLayer
{
    public class UnitOfWork : IUnitOfWork
    {
        private FMContext _fmContext;
        #region Repos
        public IUserRepository UserRepository { get; set; }
        public IRoleRepository RoleRepository { get; set; }

        public ICityRepository CityRepository { get; set; }
        public IDistrictRepository DistrictRepository { get; set; }
        public ICriteriaRepository CriteriaRepository { get; set; }
        public IFacilityRepository FacilityRepository { get; set; }
        public IHouseRepository HouseRepository { get; set; }
        public IRentRepository RentRepository { get; set; }
        public ISampleFacilityRepository SampleFacilityRepository { get; set; }
        public ISampleCriteriaRepository SampleCriteriaRepository { get; set; }
        #endregion
        public UnitOfWork()
        {
            _fmContext = new FMContext();
            #region Initialize Repos
            UserRepository = new UserRepository(_fmContext);
            RoleRepository = new RoleRepository(_fmContext);
            CityRepository = new CityRepository(_fmContext);
            DistrictRepository = new DistrictRepository(_fmContext);
            CriteriaRepository = new CriteriaRepository(_fmContext);
            FacilityRepository = new FacilityRepository(_fmContext);
            HouseRepository = new HouseRepository(_fmContext);
            RentRepository = new RentRepository(_fmContext);
            SampleFacilityRepository = new SampleFacilityRepository(_fmContext);
            SampleCriteriaRepository = new SampleCriteriaRepository(_fmContext);

            #endregion
        }

        public int Complete()
        {
            return _fmContext.SaveChanges();
        }

        public void Dispose()
        {
            _fmContext.Dispose();
        }
    }
}
