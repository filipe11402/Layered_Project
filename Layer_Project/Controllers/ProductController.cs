using Domain.Entities;
using Infrastructure.Context;
using Microsoft.AspNetCore.Mvc;
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
        private IProductRepository _productRepository;
        private readonly ApplicationDbContext _productDb;

        public ProductController()
        {
            _productRepository = new ProductRepository(_productDb);
        }

        public IActionResult Index()
        {
            IEnumerable<Product> productList = _productRepository.GetProducts();
            return View(productList);
        }
    }
}