using BlogApp.Contracts;
using BlogApp.Entities;
using GraphQL.DataLoader;
using GraphQL.Types;
using System;

namespace BlogApp.GraphQL.GraphQLTypes
{
    public class PersonType : ObjectGraphType<Person>
    {
        public PersonType(IArticleRepository articleRepository, IDataLoaderContextAccessor dataLoader)
        {
            Field(x => x.Id, type: typeof(IdGraphType)).Description("Identifier (Guid) of a person");
            Field(x => x.Username).Description("Person username");
            Field(x => x.Name).Description("Person first name");
            Field(x => x.LastName).Description("Person last name");
            Field(x => x.Email).Description("Person email");
            Field(x => x.Rank, type: typeof(PersonRankType)).Description("Person rank");
            Field<ListGraphType<ArticleType>>(
                name: "articles",
                resolve: context =>
                {
                    var loader = dataLoader.Context.GetOrAddCollectionBatchLoader<Guid, Article>("GetArticlesByAuthorIds", articleRepository.GetArticlesByAuthorIds);
                    return loader.LoadAsync(context.Source.Id);
                },
                description: "Person articles"
                );
        }
    }
}
