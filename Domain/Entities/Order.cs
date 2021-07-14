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
        public ICollection<OrderProduct> ProductList { get; set; }
        public Order()
        {
            this.ProductList = new List<OrderProduct>();
        }

        //public OrderProduct AddProducts(Product productToAdd) 
        //{
        //    OrderProduct orderRelationship = new OrderProduct() { Order = this, Product = productToAdd };

        //    ProductList.Add(orderRelationship);

        //    return orderRelationship;
        //}

    }

}
