using Application.Commands;
using Application.Mediator.Commands;
using Application.Mediator.Queries;
using Application.Queries;
using Application.ViewModels;
using AutoMapper;
using Domain.Entities;
using Infrastructure.Context;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using Project.Domain.Commands;
using Project.Domain.Entities;
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
        private readonly IMapper _mapper;

        public ProductController(IUnitOfWork unitOfWork, IMediator mediator, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mediator = mediator;
            _mapper = mapper;
        }

        public async Task<IActionResult> Index()
        {
            IEnumerable<ProductViewModel> products = await _mediator.Send(new GetProductListQuery());

            return View(products);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> PostCreate(ProductViewModel newProduct) 
        {
            CreateProductCommand productCommand = _mapper.Map<ProductViewModel, CreateProductCommand>(newProduct);
            Product handledProduct = await _mediator.Send(productCommand);

            _unitOfWork.Products.Add(handledProduct);
            await _unitOfWork.Commit();

            return RedirectToAction("Index");
        }

        [HttpPost]
        public async Task<IActionResult> PostBuy(IEnumerable<ProductViewModel> productsToBuy) 
        {
            IEnumerable<Product> productListToBuy = _mapper.Map<IEnumerable<ProductViewModel>, IEnumerable<Product>>(productsToBuy);
            await _mediator.Send(new CreateOrderCommand(productListToBuy));

            return RedirectToAction("Index");
        }

        public async Task<IActionResult> Update(int? Id) 
        {

            ProductViewModel product = await _mediator.Send(new GetProductQuery(Id));
            return View(product);
        }

        [HttpPost]
        public async Task<IActionResult> PostUpdate(ProductViewModel updatedProduct) 
        {
            await _mediator.Send(new UpdateProductCommand(updatedProduct));
            return RedirectToAction("Index");
        }
    }
}