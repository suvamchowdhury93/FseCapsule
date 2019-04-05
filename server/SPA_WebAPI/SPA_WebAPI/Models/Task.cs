using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SPA_WebAPI
{
    public class Task
    {
        public long Task_ID { get; set; }
        public long? Parent_ID { get; set; }
        public string Task_Name { get; set; }
        public DateTime? Start_Date { get; set; }
        public DateTime? End_Date { get; set; }
        public int? Priority { get; set; }
    }
}