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
    public class BSampleCriteria
    {
        public static SampleCriteriaDto CreateSampleCriteria(SampleCriteriaDto criteria)
        {
            using (var uow = new UnitOfWork())
            {
                if (criteria != null)
                {
                    ENTSampleCriteria entCriteria = new ENTSampleCriteria();
                    entCriteria.Age = criteria.Age;
                    entCriteria.PreferredGender = criteria.PreferredGender;
                    entCriteria.Cleanliness = criteria.Cleanliness;
                    entCriteria.PartyHabit = criteria.PartyHabit;
                    entCriteria.Friendship = criteria.Friendship;
                    var response = uow.SampleCriteriaRepository.FindOrAdd(entCriteria);
                    if (response == null)
                    {
                        uow.SampleCriteriaRepository.Add(entCriteria);
                        criteria.ID = entCriteria.ID;
                        return criteria;
                    }
                    else
                    {
                        SampleCriteriaDto dto = new SampleCriteriaDto();
                        dto.Age = response.Age;
                        dto.PreferredGender = response.PreferredGender;
                        dto.Cleanliness = response.Cleanliness;
                        dto.PartyHabit = response.PartyHabit;
                        dto.Friendship = response.Friendship;
                        dto.ID = response.ID;
                        return dto;
                    }

                }
                else
                {
                    return null;
                }
            }
        }


        public static SampleCriteriaDto GetByID(int id)
        {
            using (var uow = new UnitOfWork())
            {

                ENTSampleCriteria criteria = uow.SampleCriteriaRepository.GetCriteriaByID(id);
                SampleCriteriaDto criteriaDto = new SampleCriteriaDto();
                criteriaDto.ID = criteria.ID;
                criteriaDto.Age = criteria.Age;
                criteriaDto.PreferredGender = criteria.PreferredGender;
                criteriaDto.Cleanliness = criteria.Cleanliness;
                criteriaDto.PartyHabit = criteria.PartyHabit;
                criteriaDto.Friendship = criteria.Friendship;
                return criteriaDto;
            }
        }

    }
}
