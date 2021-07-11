using Domain.Interfaces;
using Infrastructure.Context;
using Project.Domain.Entities;
using Project.Domain.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Infrastructure.Repositories
{
    public class OrderRepository : IOrderRepository, IRepository<Order>
    {
        private readonly ApplicationDbContext _OrderDb;

        public OrderRepository(ApplicationDbContext orderDb)
        {
            _OrderDb = orderDb;
        }

        public Order Add(Order newOrder)
        {
            if (newOrder == null) 
            {
                throw new NullReferenceException();
            }

            return newOrder;
        }

        public IEnumerable<Order> GetAll()
        {
             throw new Exception();
        }
    }
}
