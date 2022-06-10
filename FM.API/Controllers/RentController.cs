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
    public class RentController : ControllerBase
    {
        [HttpGet("GetAll")]
        public List<RentDto> GetAll()
        {

            List<RentDto> rentDtos = BRent.GetRentAll();
            List<RentDto> rentList = new List<RentDto>();
            foreach (var item in rentDtos)
            {

                RentDto rentD = new RentDto()
                {
                    ID = item.ID,
                    RentRate=item.RentRate
                };
                rentList.Add(rentD);
            }

            return rentList;

        }
    }
}
