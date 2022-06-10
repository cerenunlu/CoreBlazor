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
    public class SampleCriteriaController : ControllerBase
    {
        [HttpPost("CreateSampleCriteria")]
        public ApiResponseDto<SampleCriteriaDto> CreateCriteria(SampleCriteriaDto sampleCriteriaDto)
        {
            var sampleCriteria = BSampleCriteria.CreateSampleCriteria(sampleCriteriaDto);
            if (sampleCriteria != null)
            {
                return ApiResponseDto<SampleCriteriaDto>.SuccessResponse(sampleCriteria, "Success");
            }
            else
            {
                return ApiResponseDto<SampleCriteriaDto>.FailedResponse("Error");

            }
        }

        [HttpGet("GetSampleCriteriaByID/{id}")]
        public SampleCriteriaDto GetSampleCriteriaByID(int id)
        {
            var sampleCriteria = BSampleCriteria.GetByID(id);
            if (sampleCriteria != null)
            {
                return sampleCriteria;
            }
            else
            {
                return null;

            }
        }


    }
}
