using BlogApp.GraphQL.GraphQLQueries;
using GraphQL;
using GraphQL.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

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
