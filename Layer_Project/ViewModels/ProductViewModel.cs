using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Application.ViewModels
{
    public class ProductViewModel
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public int ProductPrice { get; set; }
    }
}
