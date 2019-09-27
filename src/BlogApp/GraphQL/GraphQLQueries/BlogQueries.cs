using BlogApp.Contracts;
using GraphQL.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlogApp.GraphQL.GraphQLQueries
{
    public class BlogQueries : ObjectGraphType
    {
        public BlogQueries(IPersonRepository peopleRepository, IArticleRepository articleRepository)
        {
            foreach (var field in (new PersonQuery(peopleRepository)).Fields)
            {
                AddField(field);                
            }

            foreach (var field in (new ArticleQuery(articleRepository)).Fields)
            {
                AddField(field);                
            }
        }
    }
}
