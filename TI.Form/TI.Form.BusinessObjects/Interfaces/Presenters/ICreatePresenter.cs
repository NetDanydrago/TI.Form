using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TI.Form.BusinessObjects.Interfaces.Ports;

namespace TI.Form.BusinessObjects.Interfaces.Presenters
{
    public interface ICreatePresenter : ICreateOutputPort
    {
        int Id { get; }
    }
}
