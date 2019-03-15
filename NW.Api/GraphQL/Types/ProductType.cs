using GraphQL.Types;
using NW.Entities;

namespace NW.Api.GraphQL.Types
{
    public class ProductType : ObjectGraphType<Products>
    {
        public ProductType()
        {
            Field(t => t.ProductID);
            Field(t => t.ProductName).Description("Product Name");
            Field(t => t.UnitPrice, nullable:true);
			Field(t => t.QuantityPerUnit);		
			Field(t => t.Discontinued);
		}
    }
}
