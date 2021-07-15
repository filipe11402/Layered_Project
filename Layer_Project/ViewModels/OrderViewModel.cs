using Domain.Entities;
using Project.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Application.ViewModels
{
    public class OrderViewModel
    {
        public int OrderId { get; set; }
        public IEnumerable<OrderProduct> ProductList { get; set; }
    }
}
