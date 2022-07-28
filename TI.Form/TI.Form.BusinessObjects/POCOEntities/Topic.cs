using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TI.Form.BusinessObjects.POCOEntities
{
    public class Topic
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string ImageUrl { get; set; }
        public string UrlImageBackground { get; set; }
        public bool IsHtml { get; set; }
        public string TextHtml { get; set; }
        public string FormUri { get; set; }
        public DateTime LastUpdate { get; set; }
        public string ThemeId { get; set; }
    }
}
