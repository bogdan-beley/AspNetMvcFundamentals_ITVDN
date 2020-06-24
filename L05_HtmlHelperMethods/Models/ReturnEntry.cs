using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace L05_HtmlHelperMethods.Models
{
    public class ReturnEntry
    {
        public int Id { get; set; }
        public string CreatedTime { get; set; }
        public string Customer { get; set; }
        public int Quantity { get; set; }
        public string DeliveredBy { get; set; }
        public string ReceivedBy { get; set; }
        public bool IsCreated { get; set; }
    }
}