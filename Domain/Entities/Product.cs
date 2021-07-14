using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Project.Domain.Entities;

namespace Domain.Entities
{
    public class Product
    {
        [Key]
        public int ProductID { get; set; }
        [Required]
        public string ProductName { get; set; }
        [Required]
        public int ProductPrice { get; set; }
        public ICollection<OrderProduct> Orders { get; set; }



        public Product(string productName, int productPrice)
        {
            this.ProductName = productName;
            this.ProductPrice = productPrice;
        }

        public void ApplyDiscounts(int discountValue) 
        {
            if (discountValue >= this.ProductPrice) 
            {
                this.ProductPrice -= discountValue;
            }
        }
    }
}
