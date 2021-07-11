using Application.ViewModels;
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
        public IEnumerable<ProductViewModel> ProductsToBuy { get; }
    }
}
