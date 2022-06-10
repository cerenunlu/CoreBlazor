using FM.DataLayer.Entities;
using FM.DataLayer.Repository.Abstract;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FM.DataLayer.Repository.Concrete
{
    public class UserRepository : Repository<ENTUser>, IUserRepository
    {
        private FMContext _fmContext { get { return _context as FMContext; } }
        public UserRepository(DbContext fm) : base(fm)
        {
           
        }

        public ENTUser GetByEmail(string email)
        {
            return _fmContext.User.Where(m => m.Email == email).SingleOrDefault();
        }
    }
}
