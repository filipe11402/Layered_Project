using Application.Commands;
using Domain.Entities;
using MediatR;
using Project.Domain.Entities;
using Project.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace Application.CommandHandlers
{
    public class CreateOrderCommandHandler : IRequestHandler<CreateOrderCommand, Unit>
    {
        private readonly IUnitOfWork _unitOfWork;

        public CreateOrderCommandHandler(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public Task<Unit> Handle(CreateOrderCommand request, CancellationToken cancellationToken)
        {
            Order newOrder = new();
            //_unitOfWork.Orders.Add(newOrder);
            //_unitOfWork.Commit();

            foreach (var product in request.ProductsToBuy)
            {
                newOrder.ProductList.Add(product);
            }
            _unitOfWork.Orders.Update(newOrder);
            _unitOfWork.Commit();

            return Task.FromResult(Unit.Value);
        }

    }
}
