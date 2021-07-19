using Application.Queries.Interfaces;
using Application.ViewModels;
using AutoMapper;
using MediatR;
using Project.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Application.Queries
{
    public class GetOrderListQuery : IRequest<IEnumerable<OrderViewModel>>, IGetOrderListQuery
    {

    }
}
