using Application.Mediator.Queries.Interfaces;
using Application.ViewModels;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Application.Mediator.Queries
{
    public class GetProductQuery : IGetProduct, IRequest<ProductViewModel>
    {
        public int? ProductId { get; }

        public GetProductQuery(int? productId)
        {
            this.ProductId = productId;
        }
    }
}
