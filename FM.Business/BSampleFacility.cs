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
    public class BSampleFacility
    {
        public static SampleFacilityDto CreateSampleFacility(SampleFacilityDto facility)
        {
            using (var uow = new UnitOfWork())
            {
                if (facility != null)
                {
                    ENTSampleFacility entFacility = new ENTSampleFacility();
                    entFacility.CableTv = facility.CableTv;
                    entFacility.Internet = facility.Internet;
                    entFacility.WashingMachine = facility.WashingMachine;
                    entFacility.Dishwasher = facility.Dishwasher;
                    entFacility.AirConditioner = facility.AirConditioner;
                    entFacility.PetsAllowed = facility.PetsAllowed;
                    entFacility.Smoking = facility.Smoking;
                    var response = uow.SampleFacilityRepository.FindOrAdd(entFacility);
                    if (response == null)
                    {
                        uow.SampleFacilityRepository.Add(entFacility);
                        facility.ID = entFacility.ID;
                        return facility;
                    }
                    else
                    {
                        SampleFacilityDto sampleFacilityDto = new SampleFacilityDto();
                        sampleFacilityDto.CableTv = response.CableTv;
                        sampleFacilityDto.Internet = response.Internet;
                        sampleFacilityDto.WashingMachine = response.WashingMachine;
                        sampleFacilityDto.Dishwasher = response.Dishwasher;
                        sampleFacilityDto.AirConditioner = response.AirConditioner;
                        sampleFacilityDto.PetsAllowed = response.PetsAllowed;
                        sampleFacilityDto.Smoking = response.Smoking;
                        sampleFacilityDto.ID = response.ID;
                        return sampleFacilityDto;
                    }
                   
                }
                else
                {
                    return null;
                }
            }
        }

        public static SampleFacilityDto GetByID(int id)
        {
            using (var uow = new UnitOfWork())
            {
                ENTSampleFacility facility = uow.SampleFacilityRepository.GetByID(id);
                SampleFacilityDto facilityDto = new SampleFacilityDto();
                facilityDto.ID = facility.ID;
                facilityDto.CableTv = facility.CableTv;
                facilityDto.Internet = facility.Internet;
                facilityDto.WashingMachine = facility.WashingMachine;
                facilityDto.Dishwasher = facility.Dishwasher;
                facilityDto.AirConditioner = facility.AirConditioner;
                facilityDto.PetsAllowed = facility.PetsAllowed;
                facilityDto.Smoking = facility.Smoking;

                return facilityDto;
            }
        }
    }
}
