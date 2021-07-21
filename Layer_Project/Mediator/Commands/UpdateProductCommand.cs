using Application.ViewModels;
using Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Application.Mediator.Commands
{
    public class UpdateProductCommand : IRequest
    {
        public ProductViewModel ProductToUpdate { get; }
        public UpdateProductCommand(ProductViewModel productToUpdate)
        {
            this.ProductToUpdate = productToUpdate;
        }
    }
}
