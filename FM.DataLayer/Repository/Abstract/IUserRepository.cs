using FM.DataLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FM.DataLayer.Repository.Abstract
{
    public interface IUserRepository : IRepository<ENTUser>
    {
        public ENTUser GetByEmail(string email);
    }
}
