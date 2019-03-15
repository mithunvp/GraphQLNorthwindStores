using NW.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace NW.DataAccess
{
    public interface IProductRepository
    {
        Task<IList<Products>> GetAll();
    }
}
