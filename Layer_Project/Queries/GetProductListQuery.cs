using Application.Queries.Interfaces;
using Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Application.Queries
{
    public class GetProductListQuery : IGetProductListQuery, IRequest<IEnumerable<Product>>
    {
    }
}
