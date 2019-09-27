using BlogApp.Contracts;
using BlogApp.GraphQL.GraphQLTypes;
using GraphQL.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlogApp.GraphQL.GraphQLQueries
{
    public class ArticleQuery : ObjectGraphType
    {
        public ArticleQuery(IArticleRepository articleRepository)
        {
            Field<ListGraphType<ArticleType>>(
               "articles",
               arguments:
                   new QueryArguments(                        
                        new QueryArgument<StringGraphType> { Name = "email" }
                   ),
               resolve: context => 
               {
                   var articles = articleRepository.GetAll();

                   var email = context.GetArgument<string>("email");

                   if (email != null)
                   {
                       articles = articleRepository.GetArticlesForAuthor(email);
                   }

                   return articles;
                   }
            );           
        }
    }
}
