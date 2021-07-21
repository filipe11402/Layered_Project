using Application.Mediator.Commands;
using Application.ViewModels;
using AutoMapper;
using Domain.Entities;
using MediatR;
using Project.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace Application.Mediator.Handlers
{
    public class UpdateProductCommandHandler : IRequestHandler<UpdateProductCommand>
    {
        private readonly IUnitOfWork _unitOfWOrk;
        private readonly IMapper _mapper;

        public UpdateProductCommandHandler(IUnitOfWork unitOfWork, IMapper mapper)
        {
            this._unitOfWOrk = unitOfWork;
            this._mapper = mapper;
        }
        public Task<Unit> Handle(UpdateProductCommand request, CancellationToken cancellationToken)
        {
            Product updatedProduct = _mapper.Map<ProductViewModel, Product>(request.ProductToUpdate);
            _unitOfWOrk.Products.UpdateProduct(updatedProduct);
            _unitOfWOrk.Commit();
            return Task.FromResult(Unit.Value);
        }
    }
}
