﻿using System;
using System.Collections.Generic;
using System.Text;

namespace TestingTesting.Domain
{
    public class Order
    {
        public int Id { get; set; }
        public string Customer { get; set; }
        public decimal SubTotal { get; set; }
        public decimal SalesTax { get; set; }
        public decimal Shipping { get; set; }
        public decimal Discount { get; set; }
        public decimal Total { get; set; }

        public virtual List<Detail> Details { get; set; }
    }
}
