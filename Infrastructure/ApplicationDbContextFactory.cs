using Infrastructure.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Domain
{
    class ApplicationDbContextFactory: IDesignTimeDbContextFactory<ApplicationDbContext>
    {

        public ApplicationDbContext CreateDbContext(string[] args) 
        {
            var optionsBuilder = new DbContextOptionsBuilder<ApplicationDbContext>().UseSqlite(@"Data Source=Domain_Layers\ProductDb");

            return new ApplicationDbContext(optionsBuilder.Options);
        }
    }
}
