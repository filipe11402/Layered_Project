using Project.Domain.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Domain.Interfaces
{
    public interface IUnitOfWork
    {
        IProductRepository products { get; }
        Task<int> CommitAsync();
    }
}
