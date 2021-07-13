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
        public ICollection<Product> ProductList { get; set; }
        public Order()
        {
            this.ProductList = new List<Product>();
        }

        public Order AddProducts(List<Product> productListToAdd) 
        {

        foreach (var product in productListToAdd)
        {
                this.ProductList.Add(product);
        }

            return this;
        }

    }
}
