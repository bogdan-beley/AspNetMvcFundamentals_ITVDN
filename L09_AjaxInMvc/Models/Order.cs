using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace L09_AjaxInMvc.Models
{
    public class Order
    {
        public int Id { get; set; }
        public string Product { get; set; }
        public int Quantity { get; set; }
        public double Sum { get; set; }

        [DataType(DataType.Date)]
        public DateTime OrderDate { get; set; }

    }
}