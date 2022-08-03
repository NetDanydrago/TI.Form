using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TI.Form.BusinessObjects.DTOs.Create
{
    public class CreateQuestionDTO
    {
       public int TopicId { get; set; }
       public string Question { get; set; }
       public int OrderNumber { get; set; }
       public List<CreateOptionDTO> Options { get; set; }
    }
}
