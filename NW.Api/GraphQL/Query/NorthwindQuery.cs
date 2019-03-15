using GraphQL.Types;
using NW.Api.GraphQL.Types;
using NW.DataAccess;

namespace NW.Api.GraphQL.Query
{
    public class NorthwindQuery : ObjectGraphType
    {
        public NorthwindQuery(ProductRepository productRepository)
        {
            Field<ListGraphType<ProductType>>("products",
                resolve: context => productRepository.GetAll());
        }
    }
}
