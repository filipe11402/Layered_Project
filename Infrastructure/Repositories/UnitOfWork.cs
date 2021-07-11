using Infrastructure.Context;
using Project.Domain.Interfaces;
using Project.Domain.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Project.Infrastructure.Repositories
{
    class UnitOfWork : IUnitOfWork
    {
        private readonly ApplicationDbContext _productDb;
        public IProductRepository Products { get; }
        public UnitOfWork(ApplicationDbContext productDb, IProductRepository products)
        {
            _productDb = productDb;
            Products = products;
        }

        
        public Task<int> Commit()
        {
            _productDb.SaveChanges();
            return Task.FromResult(_productDb.SaveChanges());
        }
    }
}
