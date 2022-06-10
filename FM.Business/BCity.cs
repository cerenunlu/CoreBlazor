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
    public class BCity
    {
        public static List<CityDto> GetCityAll()
        {
            using (var uow = new UnitOfWork())
            {
                List<ENTCity> cities = uow.CityRepository.GetAll().ToList();
                List<CityDto> listCityDto = new List<CityDto>();
                foreach (var item in cities)
                {
                    CityDto cityDto = new CityDto()
                    {
                        ID = item.ID,
                        Name = item.Name,
                    };
                    listCityDto.Add(cityDto);
                }
                return listCityDto;
            }
        }

        public static CityDto GetCityByID(int id)
        {
            using (var uow = new UnitOfWork())
            {
                ENTCity city = uow.CityRepository.GetByID(id);
                CityDto cityDto = new CityDto()
                {
                    ID = city.ID,
                    Name = city.Name
                };
                return cityDto;
            }
        }
    }
}
