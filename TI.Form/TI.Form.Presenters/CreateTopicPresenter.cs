using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TI.Form.Presenters
{
    public class CreateTopicPresenter : ICreateTopicPresenter
    {
        public int Id { get; private set; }

        public ValueTask Handle(int id)
        {
            Id = id;
            return ValueTask.CompletedTask;
        }
    }
}
