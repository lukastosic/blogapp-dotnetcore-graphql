using GraphQL.Types;

namespace BlogApp.GraphQL.GraphQLTypes
{
    public class PersonInputType : InputObjectGraphType
    {
        public PersonInputType()
        {
            Name = "personInput";
            Field<NonNullGraphType<StringGraphType>>("email");
            Field<NonNullGraphType<StringGraphType>>("name");
            Field<NonNullGraphType<StringGraphType>>("lastName");
            Field<PersonRankType>("rank");
        }
    }
}
