using BlogApp.Entities;
using GraphQL.Types;

namespace BlogApp.GraphQL.GraphQLTypes
{
    public class ArticleType : ObjectGraphType<Article>
    {
        public ArticleType()
        {
            Field(x => x.Id, type: typeof(IdGraphType)).Description("Article ID");
            Field(x => x.Slug).Description("Article slug");
            Field(x => x.Title).Description("Article title");
            Field(x => x.Description).Description("Article description");
            Field(x => x.Content).Description("Article content in Markdown format");
            Field(x => x.AuthorId, type: typeof(IdGraphType)).Description("Article authord ID");
            Field(x => x.Author, type: typeof(PersonType)).Description("Author of an article");
        }
    }
}
