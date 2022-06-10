using FM.Business;
using FM.DTOs;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FM.API.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class HousePostController : ControllerBase
    {
        [HttpGet("GetAll")]
        public List<HouseDto> GetAll()
        {
            var house = BHouse.GetHouseAll();
            List<HouseDto> listHouse = new List<HouseDto>();
            foreach (var item in house)
            {

                HouseDto houseDto = new HouseDto()
                {
                    ID = item.ID,
                    Header = item.Header,
                    Description = item.Description,
                    CreateDate = item.CreateDate,
                    Size = item.Size,
                    CityID = item.CityID,
                    SampleCriteriaID = item.SampleCriteriaID,
                    Address = item.Address,
                    MovingIn = item.MovingIn,
                    Deposit = item.Deposit,
                    SampleFacilityID = item.SampleFacilityID,
                    Period = item.Period,
                    Pay = item.Pay,
                    DistrictID = item.DistrictID,
                    UserID = item.UserID,

                };
                listHouse.Add(houseDto);
            }

            return listHouse;

        }

        [HttpGet("GetHouseListByUserID/{id}")]
        public List<HouseDto> GetHouseByUserID(int id)
        {
            var house = BHouse.GetHousesById(id);

            if (house == null || !house.Any())
            {
                return house;

            }
            else
            {
                return house;
            }
        }

        [HttpPost("CreateNewHouse")]
        public ApiResponseDto<HouseDto> CreateHousePost(HouseDto house)
        {
            var newhouse = BHouse.CreateNew(house);
            if(newhouse == null){
                return ApiResponseDto<HouseDto>.FailedResponse("basarisiz");
            }
            else
            {
                return ApiResponseDto<HouseDto>.SuccessResponse(newhouse, "Success");
            }
        }


        [HttpGet("SeeHouseDetail/{id}")]
        public HouseDto SeeHouseDetail(int id)
        {
            var house = BHouse.GetHouseByHouseID(id);
            if (house == null)
            {
                return null;
            }
            else
            {
                return house;
            }
        }


    }
}
