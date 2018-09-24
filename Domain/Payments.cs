﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Domain
{
    public class Payments
    {
        [Key]
        public int id { get; set; }
        public String Date { get; set; }
        public float AmountInPer { get; set; }
        public String RecitNo { get; set; }
    }
}
