using Application.ViewModels;
using Domain.Entities;
using Infrastructure.Context;
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
        private IUnitOfWork _unitOfWork;

        public ProductController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public IActionResult Index()
        {
            ProductViewModel products = new ProductViewModel();

            products.productList = _unitOfWork.products.GetProducts();

            return View(products);
        }
    }
}