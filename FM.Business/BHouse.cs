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
    public class BHouse
    {
        public static List<HouseDto> GetHouseAll()
        {
            using (var uow = new UnitOfWork())
            {
                List<ENTHouse> houses = uow.HouseRepository.GetAll().ToList();
                List<HouseDto> listHouseDto = new List<HouseDto>();
                foreach (var item in houses)
                {
                    HouseDto houseDto = new HouseDto()
                    {
                        ID = item.ID,
                        Header = item.Header,
                        Description = item.Description,
                        CreateDate = item.CreateDate,
                        Size = item.Size,
                        Period = item.Period,
                        MovingIn = item.MovingIn,
                        Address = item.Address,
                        Deposit = item.Deposit,
                        SampleCriteriaID = item.SampleCriteriaID,
                        SampleFacilityID = item.SampleFacilityID,
                        CityID = item.CityID,
                        Pay = item.Pay,
                        DistrictID = item.DistrictID,
                        UserID = item.UserID,
                    };
                    listHouseDto.Add(houseDto);
                }
                return listHouseDto;
            }
        }

        public static List<HouseDto> GetHouseByAge(List<HouseDto> houseList)
        {
            using (var uow = new UnitOfWork())
            {
                List<ENTHouse> houses = uow.HouseRepository.GetAll().ToList();
                List<HouseDto> listHouseDto = new List<HouseDto>();
                foreach (var item in houses)
                {
                    HouseDto houseDto = new HouseDto()
                    {
                        ID = item.ID,
                        Header = item.Header,
                        Description = item.Description,
                        CreateDate = item.CreateDate,
                        Size = item.Size,
                        Period = item.Period,
                        MovingIn = item.MovingIn,
                        Address = item.Address,
                        Deposit = item.Deposit,
                        SampleCriteriaID = item.SampleCriteriaID,
                        SampleFacilityID = item.SampleFacilityID,
                        CityID = item.CityID,
                        Pay = item.Pay,
                        DistrictID = item.DistrictID,
                    };
                    listHouseDto.Add(houseDto);
                }
                return listHouseDto;
            }
        }

        public static List<HouseDto> GetHousesById(int id)
        {
            using (var uow = new UnitOfWork())
            {
                List<ENTHouse> houses = uow.HouseRepository.GetByUserID(id).ToList();
                List<HouseDto> listHouseDto = new List<HouseDto>();

                foreach (var item in houses)
                {
                    HouseDto houseDto = new HouseDto()
                    {
                        ID = item.ID,
                        Header = item.Header,
                        Description = item.Description,
                        SampleFacilityID = item.SampleFacilityID,
                        SampleCriteriaID = item.SampleCriteriaID,
                        CreateDate = item.CreateDate,
                        CityID = item.CityID,
                        DistrictID = item.DistrictID,
                        Address = item.Address,
                        Deposit = item.Deposit,
                        Pay = item.Pay,
                        MovingIn = item.MovingIn,
                        Period = item.Period,
                        Size = item.Size,
                        UserID = item.UserID,
                    };
                    listHouseDto.Add(houseDto);
                }
                return listHouseDto;
            }
        }

        public static HouseDto GetHouseByHouseID(int id)
        {
            using (var uow = new UnitOfWork())
            {
                ENTHouse house = uow.HouseRepository.GetByID(id);
                HouseDto HouseDto = new HouseDto();

                    HouseDto houseDto = new HouseDto()
                    {
                        ID = house.ID,
                        Header = house.Header,
                        Description = house.Description,
                        SampleFacilityID = house.SampleFacilityID,
                        SampleCriteriaID = house.SampleCriteriaID,
                        CreateDate = house.CreateDate,
                        CityID = house.CityID,
                        DistrictID = house.DistrictID,
                        Address = house.Address,
                        Deposit = house.Deposit,
                        Pay = house.Pay,
                        MovingIn = house.MovingIn,
                        Period = house.Period,
                        Size = house.Size,
                        UserID = house.UserID,
                    };
                 
                return houseDto;
            }
        }


        public static HouseDto CreateNew(HouseDto house)
        {
            using (var uow = new UnitOfWork())
            {
                if (house != null)
                {
                    ENTHouse entHouse = new ENTHouse()
                    {
                        Header = house.Header,
                        Description = house.Description,
                        CreateDate = house.CreateDate,
                        CityID = house.CityID,
                        DistrictID = house.DistrictID,
                        Address = house.Address,
                        Deposit = house.Deposit,
                        Pay = house.Pay,
                        SampleFacilityID = house.SampleFacilityID,
                        SampleCriteriaID = house.SampleCriteriaID,
                        MovingIn = house.MovingIn,
                        Period = house.Period,
                        Size = house.Size,
                        UserID = house.UserID,
                    };

                    uow.HouseRepository.Add(entHouse);
                    house.ID = entHouse.ID;
                    return house;
                }
                else
                {
                    return null;
                }
            }
        }
    }
}
