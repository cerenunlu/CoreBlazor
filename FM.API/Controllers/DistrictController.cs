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
    public class DistrictController : ControllerBase
    {
        [HttpGet("GetAll/{id}")]
        public List<DistrictDto> GetAll(int id)
        {

            List<DistrictDto> district = BDistrict.GetDistrictByCity(id);
            List<DistrictDto> listDistrict = new List<DistrictDto>();
            foreach (var item in district)
            {

                DistrictDto districtDto = new DistrictDto()
                {
                    ID = item.ID,
                    Name = item.Name,
                };
                listDistrict.Add(districtDto);
            }

            return listDistrict;

        }
    }
}
