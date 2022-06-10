using FM.Business;
using FM.DTOs;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Caching.Memory;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FM.API.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class CriteriaController : ControllerBase
    {
     

        [HttpGet("GetAll")]
        public List<CriteriaDto> GetAll()
        {
            var criteria = BCriteria.GetCriteriaAll();
            List<CriteriaDto> listCriteria = new List<CriteriaDto>();
            foreach (var item in criteria)
            {

                CriteriaDto criteriaDto = new CriteriaDto()
                {
                    ID = item.ID,
                    Name = item.Name,
                };
                listCriteria.Add(criteriaDto);
            }

            return listCriteria;

        }



        [HttpPost("CreateCriteria")]
        public ApiResponseDto<CriteriaDto> CreateCriteria(CriteriaDto criteriaDto)
        {
            var criteria = BCriteria.CreateCriteria(criteriaDto);
            if (criteria != null)
            {
                return ApiResponseDto<CriteriaDto>.SuccessResponse(criteria, "Success");
            }
            else
            {
                return ApiResponseDto<CriteriaDto>.FailedResponse("Error");

            }
        }
    }
}
