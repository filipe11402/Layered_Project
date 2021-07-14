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
    public class OrderProductRepository : IOrderProductRepository, IRepository<OrderProduct>
    {
        private readonly ApplicationDbContext _orderProductDb;

        public OrderProductRepository(ApplicationDbContext orderProductDb)
        {
            _orderProductDb = orderProductDb;
        }

        public OrderProduct Add(OrderProduct newOrderProduct)
        {
            _orderProductDb.OrderProducts.Add(newOrderProduct);
            return newOrderProduct;
        }

        public IEnumerable<OrderProduct> GetAll()
        {
            return _orderProductDb.OrderProducts;
        }
    }
}
