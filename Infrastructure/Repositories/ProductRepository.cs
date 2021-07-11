using Domain.Entities;
using Domain.Interfaces;
using Infrastructure.Context;
using Project.Domain.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Infrastructure.Repositories
{
    public class ProductRepository : IProductRepository, IRepository<Product>
    {
        private readonly ApplicationDbContext _productDb;

        public ProductRepository(ApplicationDbContext productDb)
        {
            _productDb = productDb;
        }

        public IEnumerable<Product> GetAll()
        {
            IEnumerable<Product> productList = _productDb.Products;
            return productList;
        }

        public Product Add(Product newProduct)
        {
            if (newProduct == null) 
            {
                
            }
            _productDb.Add(newProduct);
            return newProduct;
        }
    }
}
