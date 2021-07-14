using Application.Commands;
using Domain.Entities;
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


        public async Task<Order> Handle(CreateOrderCommand request, CancellationToken cancellationToken)
        {

            Order newOrder = new();

            //foreach (var product in request.ProductsToBuy) 
            //{
            //    product.ApplyDiscounts(2);
            //}

            newOrder.AddProducts(request.ProductsToBuy);

            return await Task.FromResult(newOrder);
        }
    }
}
