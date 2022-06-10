using FM.Business;
using FM.DTOs;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Caching.Memory;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FM.API.Controller
{
    [Route("[controller]")]
    [ApiController]
    public class FacilityController : ControllerBase
    {
       

        [HttpGet("GetAll")]
        public List<FacilityDto> GetAll()
        {
            var facility = BFacility.GetFacilityAll();
            List<FacilityDto> listFacility = new List<FacilityDto>();
            foreach (var item in facility)
            {

                FacilityDto facilityDto = new FacilityDto()
                {
                    ID = item.ID,
                    Name = item.Name,
                };
                listFacility.Add(facilityDto);
            }

            return listFacility;

        }

        [HttpPost("CreateFacility")]
        public ApiResponseDto<FacilityDto> CreateFacility(FacilityDto facilityDto)
        {
            var facility = BFacility.CreateFacility(facilityDto);
            if (facility != null)
            {
                return ApiResponseDto<FacilityDto>.SuccessResponse(facility, "Success");
            }
            else
            {
                return ApiResponseDto<FacilityDto>.FailedResponse("Error");

            }
        }
    }
}
