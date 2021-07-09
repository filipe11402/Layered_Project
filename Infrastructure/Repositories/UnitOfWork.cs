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
        public UnitOfWork(ApplicationDbContext productDb)
        {
            _productDb = productDb;
        }

        public IProductRepository products { get; }

        public Task<int> CommitAsync()
        {
            return _productDb.SaveChangesAsync();
        }
    }
}
