using Application.Mediator.Queries;
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
    public class GetProductQueryHandler : IRequestHandler<GetProductQuery, ProductViewModel>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;
        public GetProductQueryHandler(IUnitOfWork unitOfWork, IMapper mapper)
        {
            this._unitOfWork = unitOfWork;
            this._mapper = mapper;
        }
        public async Task<ProductViewModel> Handle(GetProductQuery request, CancellationToken cancellationToken)
        {
            Product product = _unitOfWork.Products.GetById(request.ProductId);
            ProductViewModel productToView = _mapper.Map<Product, ProductViewModel>(product);
            return await Task.FromResult(productToView);
        }
    }
}
