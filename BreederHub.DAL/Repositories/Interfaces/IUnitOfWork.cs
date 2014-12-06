using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BreederHub.DAL.Repositories.Interfaces
{
    interface IUnitOfWork : IDisposable
    {
        bool Save();
    }
}
