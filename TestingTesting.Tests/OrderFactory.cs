﻿using System;
using System.Collections.Generic;
using System.Text;
using TestingTesting.Domain;

namespace TestingTesting.Tests
{
    public static class OrderFactory
    {
        public static Order ValidNoDiscounts()
        {
            var order = new Order()
            {
                Id = 1001,
                Customer = "Jim Kirk"
            };

            order.Details = new List<OrderDetail>();

            throw new NotImplementedException();
        }

        public static OrderDetail ValidGenTaxedSmall()
        {
            throw new NotImplementedException();
        }
    }
}
