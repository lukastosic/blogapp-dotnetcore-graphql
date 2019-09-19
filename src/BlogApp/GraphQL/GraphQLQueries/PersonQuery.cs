using BlogApp.Contracts;
using BlogApp.GraphQL.GraphQLTypes;
using GraphQL;
using GraphQL.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlogApp.GraphQL.GraphQLQueries
{
    public class PersonQuery : ObjectGraphType
    {
        public PersonQuery(IPersonRepository repository)
        {
            Field<ListGraphType<PersonType>>(
               "people",
               resolve: context => repository.GetAll()
            );

            Field<PersonType>(
                "person",
                arguments:
                    new QueryArguments(
                        new QueryArgument<IdGraphType> { Name = "personId" },
                        new QueryArgument<StringGraphType> { Name = "email"}
                        ),
                resolve: context =>
                {
                    Guid id;
                    bool idSet = false;

                    if (context.GetArgument<string>("personId") != null)
                    {
                        if (!Guid.TryParse(context.GetArgument<string>("personId"), out id))
                        {
                            context.Errors.Add(new ExecutionError("Wrong value for GUID"));
                            return null;
                        }
                        else
                        {
                            return repository.GetById(id);
                        }
                    }

                    var email = context.GetArgument<string>("email");
                    if (email != null)
                    {
                        return repository.GetByEmail(email);
                    }

                    return null;
                }
                );
        }
    }
}
