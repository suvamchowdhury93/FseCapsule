using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SPA_BL
{
    public class SearchRequest
    {
        public string TaskName { get; set; }
        public string ParentTask { get; set; }
        public int? PriorityFrom { get; set; }
        public int? PriorityTo { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
    }
}