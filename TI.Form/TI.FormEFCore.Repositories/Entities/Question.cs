using System;
using System.Collections.Generic;
using System.Text;

namespace TI.FormEFCore.Repositories.Entities
{
    public class Question
    {
        public int Id { get; set; }
        public string Text { get; set; }
        public int OrderNumber { get; set; }


        public List<Option> Options { get; set; }
        public Topic Topic { get; set; }
        public int TopicId { get; set; }
    }
}
