﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TI.Form.BusinessObjects.Interfaces.Ports
{
    internal interface ICreateTopicOutputPort
    {
        ValueTask Handle(int topicId);
    }
}