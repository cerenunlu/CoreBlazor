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
    public class BDistrict
    {
        public static List<DistrictDto> GetDistrictByCity(int cityID)
        {
            using (var uow = new UnitOfWork())
            {
                List<ENTDistrict> districtList = uow.DistrictRepository.GetByCityID(cityID);
                List<DistrictDto> districtDtoList = new List<DistrictDto>();
                foreach (var item in districtList)
                {
                    DistrictDto districtDto = new DistrictDto()
                    {
                        ID = item.ID,
                        Name = item.Name,
                    };
                    districtDtoList.Add(districtDto);
                }
                return districtDtoList;
            }
        }
    }
}
