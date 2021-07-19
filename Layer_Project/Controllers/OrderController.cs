using Application.Queries;
using Application.ViewModels;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using Project.Domain.Entities;
using Project.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Application.Controllers
{
    public class OrderController : Controller
    {
        private readonly IMediator _mediator;

        public OrderController(IMediator mediator)
        {
            _mediator = mediator;
        }

        public async Task<IActionResult> Index()
        {
            IEnumerable<OrderViewModel> orderList = await _mediator.Send(new GetOrderListQuery()); 

            return View(orderList);
        }
    }
}
