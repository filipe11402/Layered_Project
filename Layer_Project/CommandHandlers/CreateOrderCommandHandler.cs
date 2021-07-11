using Application.Commands;
using MediatR;
using Project.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace Application.CommandHandlers
{
    public class CreateOrderCommandHandler : IRequestHandler<CreateOrderCommand, Order>
    {

        public Task<Order> Handle(CreateOrderCommand request, CancellationToken cancellationToken)
        {
            Order newOrder = new();

            //newOrder.AddProducts();
            return;
        }
    }
}
