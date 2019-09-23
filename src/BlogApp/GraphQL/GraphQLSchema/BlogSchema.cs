using BlogApp.GraphQL.GraphQLQueries;
using GraphQL;
using GraphQL.Types;

namespace BlogApp.GraphQL.GraphQLSchema
{
    public class BlogSchema : Schema
    {
        public BlogSchema(IDependencyResolver resolver)
        : base(resolver)
        {
            Query = resolver.Resolve<PersonQuery>();
            Mutation = resolver.Resolve<PersonMutation>();
        }
    }
}
