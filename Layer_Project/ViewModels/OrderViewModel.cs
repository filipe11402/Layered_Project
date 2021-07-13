using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Application.ViewModels
{
    public class OrderViewModel
    {
        public int OrderId { get; set; }
        public List<Product> ProductList { get; set; }
    }
}
