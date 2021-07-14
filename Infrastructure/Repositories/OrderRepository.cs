using Domain.Entities;
using Domain.Interfaces;
using Infrastructure.Context;
using Microsoft.EntityFrameworkCore;
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
        private readonly ApplicationDbContext _orderDb;

        public OrderRepository(ApplicationDbContext orderDb)
        {
            _orderDb = orderDb;
        }

        public Order Add(Order newOrder)
        {
            _orderDb.Orders.Add(newOrder);
            return newOrder;
        }

        public IEnumerable<Order> GetAll()
        {
            return _orderDb.Orders.Include(x => x.ProductList);
        }

        public void Update(Order orderToUpdate)
        {
            _orderDb.Update(orderToUpdate);
        }
    }
}
