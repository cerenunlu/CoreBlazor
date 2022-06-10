using FM.DataLayer;
using FM.DataLayer.Entities;
using FM.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FM.Business
{
    public class BFacility
    {
        public static List<FacilityDto> GetFacilityAll()
        {
            using (var uow = new UnitOfWork())
            {
                List<ENTFacility> facilities = uow.FacilityRepository.GetAll().ToList();
                List<FacilityDto> listFacilityDto = new List<FacilityDto>();
                foreach (var item in facilities)
                {
                    FacilityDto facilityDto = new FacilityDto()
                    {
                        ID = item.ID,
                        Name = item.Name,
                    };
                    listFacilityDto.Add(facilityDto);
                }
                return listFacilityDto;
            }
        }

        public static ENTFacility GetFacilityByID(int id)
        {
            using (var uow = new UnitOfWork())
            {
                return uow.FacilityRepository.GetByID(id);
            }
        }

        public static FacilityDto CreateFacility(FacilityDto facilityDto)
        {
            using (var uow = new UnitOfWork())
            {
                if (facilityDto != null)
                {
                    ENTFacility entFacility = new ENTFacility();
                    entFacility.Name = facilityDto.Name;

                    uow.FacilityRepository.Add(entFacility);
                    facilityDto.ID = entFacility.ID;
                    return facilityDto;
                }
                else
                {
                    return null;
                }
            }
        }
        public static void Update(FacilityDto facilityDto)
        {
            if (facilityDto == null || DBNull.Value.Equals(facilityDto))
            {
                return;
            }
            using (var uow = new UnitOfWork())
            {
                ENTFacility eNTFacility = new ENTFacility();
                eNTFacility.ID = facilityDto.ID;
                eNTFacility.Name = facilityDto.Name;
                uow.FacilityRepository.Save(eNTFacility);
            }
        }
        public static void Delete(int id)
        {
            using (var uow = new UnitOfWork())
            {

                uow.FacilityRepository.Remove(id);
            }
        }
    }
}
