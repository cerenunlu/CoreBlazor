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
    public class CityController : ControllerBase
    {
       

        [HttpGet("GetAll")]
        public List<CityDto> GetAll()
        {
            var city = BCity.GetCityAll();
            List<CityDto> listCity = new List<CityDto>();
            foreach (var item in city)
            {

                CityDto cityDto = new CityDto()
                {
                    ID = item.ID,
                    Name = item.Name,
                };
                listCity.Add(cityDto);
            }

            return listCity;

        }


        [HttpGet("GetCityByID/{id}")]
        public CityDto GetCityByID(int id)
        {
            var city = BCity.GetCityByID(id);
            return city;

        }
    }
}
