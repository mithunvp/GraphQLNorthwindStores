using GraphQL;
using GraphQL.Types;
using NW.Api.GraphQL.Query;

namespace NW.Api.GraphQL
{
    public class NorthwindSchema : Schema
    {
        public NorthwindSchema(IDependencyResolver resolver) : base(resolver)
        {
            Query = resolver.Resolve<NorthwindQuery>();
        }
    }
}
