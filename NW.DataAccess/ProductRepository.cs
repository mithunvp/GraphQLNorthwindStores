using Microsoft.EntityFrameworkCore;
using NW.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace NW.DataAccess
{
    public class ProductRepository : IProductRepository
    {
        private readonly NorthwindContext _dbContext;

        public ProductRepository(NorthwindContext dbcontext)
        {
            _dbContext = dbcontext;
        }
        public async Task<IList<Products>> GetAll()
        {
            return await _dbContext.Products.ToListAsync();
        }
    }
}
