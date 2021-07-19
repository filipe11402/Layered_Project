using Domain.Entities;
using Domain.Interfaces;
using MediatR;
using Project.Domain.Commands;
using Project.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Project.Domain.CommandHandlers
{
    public class CreateProductCommandHandler : IRequestHandler<CreateProductCommand, Product>
    {
        public async Task<Product> Handle(CreateProductCommand request, CancellationToken cancellationToken)
        {
            Product newProduct = new(request.ProductName, request.ProductPrice);

            return await Task.FromResult(newProduct);
        }
    }
}
