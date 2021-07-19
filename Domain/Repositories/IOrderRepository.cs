using Domain.Entities;
using Project.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Domain.Repositories
{
    public interface IOrderRepository
    {
        IEnumerable<Order> GetAll();

        void Update(Order orderToUpdate);

        Order Add(Order newOrder);
    }
}
