using Application.Queries;
using Domain.Entities;
using MediatR;
using Project.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace Application.QueryHandlers
{
    public class GetProductListQueryHandler : IRequestHandler<GetProductListQuery, IEnumerable<Product>>
    {

        private readonly IUnitOfWork _unitOfWork;

        public GetProductListQueryHandler(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }


        public async Task<IEnumerable<Product>> Handle(GetProductListQuery request, CancellationToken cancellationToken)
        {
            IEnumerable<Product> productList = _unitOfWork.Products.GetAll();
            return await Task.FromResult(productList);
        }
    }
}
