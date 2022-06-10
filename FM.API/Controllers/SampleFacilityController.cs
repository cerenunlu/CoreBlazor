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
    public class SampleFacilityController : ControllerBase
    {
        [HttpPost("CreateSampleFacility")]
        public ApiResponseDto<SampleFacilityDto> CreateFacility(SampleFacilityDto sampleFacilityDto)
        {
            var sampleFacility = BSampleFacility.CreateSampleFacility(sampleFacilityDto);
            if (sampleFacility != null)
            {
                return ApiResponseDto<SampleFacilityDto>.SuccessResponse(sampleFacility, "Success");
            }
            else
            {
                return ApiResponseDto<SampleFacilityDto>.FailedResponse("Error");

            }
        }

        [HttpGet("GetSampleFacilityByID/{id}")]
        public SampleFacilityDto GetSampleFacilityByID(int id)
        {
            var sampleFacility = BSampleFacility.GetByID(id);
            if (sampleFacility != null)
            {
                return sampleFacility;
            }
            else
            {
                return null;

            }
        }
    }
}
