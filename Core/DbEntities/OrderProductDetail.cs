﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using OnlineShopping.Core.DbEntities;

namespace OnlineShopping.Core.DbEntities
{
    public class OrderProductDetail
    {
        public int Id { get; set; }
        public int Price { get; set; }
        public int Quantity { get; set; }
        [ForeignKey("ProductId")]
        public int ProductId { get; set; }
        [ForeignKey("OrderId")]
        public int OrderId { get; set; }


        public Product Product { get; set; }
        public Order Order { get; set; }
    }
}
