using System;
using System.Collections.Generic;
using System.Text;

namespace TI.Form.BusinessObjects.ValueObjects
{
    public class OptionQuestion
    {
        public int ID { get; set; }
        public string Question { get; set; }
        public bool IsRequiere { get; set; }
        public bool IsMultipleAnswser { get; set; }
        public int OrderNumber { get; set; }

        public List<Option> Options { get; set; }
    }
}
