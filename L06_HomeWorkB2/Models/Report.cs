using L06_HomeWorkB2.Controllers;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace L06_HomeWorkB2.Models
{
    public class Report
    {
        [DataType(DataType.Date)]
        public DateTime FromDate { get; set; }

        [DataType(DataType.Date)]
        public DateTime ToDate { get; set; }

        public string Search { get; set; }
    }
}