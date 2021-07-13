using Application.ViewModels;
using Domain.Entities;
using MediatR;
using Project.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Application.Commands
{
    public class CreateOrderCommand : IRequest<Order>
    {
        public IEnumerable<Product> ProductsToBuy { get; set; }

        public CreateOrderCommand(IEnumerable<Product> productsToBuy)
        {
            ProductsToBuy = productsToBuy;
        }
    }
}
