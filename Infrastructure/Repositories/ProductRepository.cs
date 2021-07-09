﻿using Domain.Entities;
using Infrastructure.Context;
using Project.Domain.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Infrastructure.Repositories
{
    public class ProductRepository : IProductRepository
    {
        private readonly ApplicationDbContext _productDb;

        public ProductRepository(ApplicationDbContext productDb)
        {
            _productDb = productDb;
        }

        public IEnumerable<Product> GetProducts()
        {
            IEnumerable<Product> productList = _productDb.Products;
            return productList;
        }
    }
}