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
    public class BCriteria
    {
        public static List<CriteriaDto> GetCriteriaAll()
        {
            using (var uow = new UnitOfWork())
            {
                List<ENTCriteria> criterias = uow.CriteriaRepository.GetAll().ToList();
                List<CriteriaDto> listCriteriaDto = new List<CriteriaDto>();
                foreach (var item in criterias)
                {
                    CriteriaDto criteriaDto = new CriteriaDto()
                    {
                        ID = item.ID,
                        Name = item.Name,
                    };
                    listCriteriaDto.Add(criteriaDto);
                }
                return listCriteriaDto;
            }
        }

        public static ENTCriteria GetCriteriaByID(int id)
        {
            using (var uow = new UnitOfWork())
            {
                return uow.CriteriaRepository.GetByID(id);
            }
        }
        public static CriteriaDto CreateCriteria(CriteriaDto criteriaDto)
        {
            using (var uow = new UnitOfWork())
            {
                if (criteriaDto != null)
                {
                    ENTCriteria entCriteria = new ENTCriteria();
                    entCriteria.Name = criteriaDto.Name;

                    uow.CriteriaRepository.Add(entCriteria);
                    criteriaDto.ID = entCriteria.ID;
                    return criteriaDto;
                }
                else
                {
                    return null;
                }
            }
        }
        public static void Update(CriteriaDto criteriaDto)
        {
            if (criteriaDto == null || DBNull.Value.Equals(criteriaDto))
            {
                return;
            }
            using (var uow = new UnitOfWork())
            {
                ENTCriteria eNTCriteria = new ENTCriteria();
                eNTCriteria.ID = criteriaDto.ID;
                eNTCriteria.Name = criteriaDto.Name;
                uow.CriteriaRepository.Save(eNTCriteria);
            }
        }
        public static void Delete(int id)
        {
            using (var uow = new UnitOfWork())
            {

                uow.CriteriaRepository.Remove(id);
            }
        }
    }
}
