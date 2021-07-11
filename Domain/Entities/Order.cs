﻿using Domain.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Domain.Entities
{
    public class Order
    {
        [Key]
        public int OrderId { get; set; }
        public IEnumerable<Product> ProductList { get; set; }

        public Order()
        {
            ProductList = new List<Product>();
        }

        protected Order AddProducts(IEnumerable<Product> productListToAdd) 
        {
            ProductList.Concat(productListToAdd);

            return this;
        }

    }
}
