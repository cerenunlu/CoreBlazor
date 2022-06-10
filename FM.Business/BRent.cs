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
    public class BRent
    {
        public static List<RentDto> GetRentAll()
        {
            using (var uow = new UnitOfWork())
            {
                List<ENTRent> rentList = uow.RentRepository.GetAll().ToList();
                List<RentDto> rentDtoList = new List<RentDto>();
                foreach (var item in rentList)
                {
                    RentDto rentDto = new RentDto()
                    {
                        ID = item.ID,
                       RentRate=item.RentRate
                    };
                    rentDtoList.Add(rentDto);
                }
                return rentDtoList;
            }
        }
    }
}
