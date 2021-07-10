using Application.Queries;
using Application.ViewModels;
using Domain.Entities;
using Infrastructure.Context;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using Project.Domain.Interfaces;
using Project.Domain.Repositories;
using Project.Infrastructure.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Application.Controllers
{
    public class ProductController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMediator _mediator;

        public ProductController(IUnitOfWork unitOfWork, IMediator mediator)
        {
            _unitOfWork = unitOfWork;
            _mediator = mediator;
        }

        public async Task<IActionResult> Index()
        {
            ProductViewModel products = new();

            products.productList = await _mediator.Send(new GetProductListQuery());

            return View(products);
        }

        public IActionResult Create() 
        {
            return View();
        }
    }
}