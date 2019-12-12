﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace UsingModel.Models
{
    public class Customer
    {
        [Display(Name = "รหัสลูกค้า")]
        public string CustomerID { get; set; }
        [Display(Name = "ชื่อลูกค้า")]
        public string FullName { get; set; }
        [Display(Name = "ที่อยู่")]
        public string Address { get; set; }
    }
}
