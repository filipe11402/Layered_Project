using Application.Queries;
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

namespace Application.QueryHandlers
{
    public class GetProductListQueryHandler : IRequestHandler<GetProductListQuery, IEnumerable<ProductViewModel>>
    {
        private readonly IMapper _mapper;
        private readonly IUnitOfWork _unitOfWork;

        public GetProductListQueryHandler(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }


        public async Task<IEnumerable<ProductViewModel>> Handle(GetProductListQuery request, CancellationToken cancellationToken)
        {


            IEnumerable<Product> repositoryProductList = _unitOfWork.Products.GetAll();

            IEnumerable<ProductViewModel> viewModelProductList = _mapper.Map<IEnumerable<Product>, IEnumerable<ProductViewModel>>(repositoryProductList);

            return await Task.FromResult(viewModelProductList);
        }
    }
}
