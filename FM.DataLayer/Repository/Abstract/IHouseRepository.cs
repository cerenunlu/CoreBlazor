using FM.DataLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FM.DataLayer.Repository.Abstract
{
    public interface IHouseRepository : IRepository<ENTHouse>
    {
        public List<ENTHouse> GetByUserID(int id);

       
    }
}
