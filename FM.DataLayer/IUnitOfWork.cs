using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FM.DataLayer
{
    public interface IUnitOfWork : IDisposable
    {
        public int Complete();
    }
}
