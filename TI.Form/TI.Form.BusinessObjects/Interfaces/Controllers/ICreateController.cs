using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TI.Form.BusinessObjects.DTOs.Create;

namespace TI.Form.BusinessObjects.Interfaces.Controllers
{
    public interface ICreateController
    {
        ValueTask<int> CreateOrder(CreateDTO createOrderDTO);
    }
}
