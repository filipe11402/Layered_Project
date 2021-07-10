using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Domain.Repositories
{
    public interface IProductRepository
    {
        IEnumerable<Product> GetAll();

        Product Add(Product newProduct);
    }
}
