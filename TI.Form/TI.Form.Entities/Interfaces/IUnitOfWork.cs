using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TI.Form.Entities.Interfaces
{
    public interface IUnitOfWork
    {
        ValueTask SaveChanges();
    }
}
