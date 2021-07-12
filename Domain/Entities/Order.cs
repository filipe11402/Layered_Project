using Domain.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Domain.Entities
{
    public class Order
    {
        [Key]
        public int OrderId { get; set; }
        public virtual IEnumerable<Product> ProductList { get; private set; }
        public Order()
        {

        }

        public Order AddProducts(IEnumerable<Product> productListToAdd) 
        {
            this.ProductList = productListToAdd;

            return this;
        }

    }
}
