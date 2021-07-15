using Application.Queries;
using Application.ViewModels;
using AutoMapper;
using MediatR;
using Project.Domain.Entities;
using Project.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace Application.QueryHandlers
{
    public class GetOrderListQueryHandler : IRequestHandler<GetOrderListQuery, IEnumerable<OrderViewModel>>
    {

        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public GetOrderListQueryHandler(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public async Task<IEnumerable<OrderViewModel>> Handle(GetOrderListQuery request, CancellationToken cancellationToken)
        {
            IEnumerable<Order> allOrders =  _unitOfWork.Orders.GetAll();
            IEnumerable<OrderViewModel> orderList = _mapper.Map<IEnumerable<Order>, IEnumerable<OrderViewModel>> (allOrders);

            return await Task.FromResult(orderList);
        }
    }
}
