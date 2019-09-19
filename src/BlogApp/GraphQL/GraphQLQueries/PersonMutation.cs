using BlogApp.Contracts;
using BlogApp.Entities;
using BlogApp.GraphQL.GraphQLTypes;
using GraphQL;
using GraphQL.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlogApp.GraphQL.GraphQLQueries
{
    public class PersonMutation : ObjectGraphType
    {
        public PersonMutation(IPersonRepository personRepository)
        {
            Field<PersonType>(
                "createPerson",
                arguments: new QueryArguments(
                    new QueryArgument<NonNullGraphType<PersonInputType>> { Name = "person", Description = "# Person details for creating new person" }),
                resolve: context =>
                {
                   
                    var person = context.GetArgument<Person>("person");

                    var existingPerson = personRepository.GetByEmail(person.Email);

                    if (existingPerson!=null)
                    {
                        context.Errors.Add(new ExecutionError("Email already exist"));
                        return null;
                    }

                    return personRepository.CreatePerson(person);
                }
                );
        }
    }
}
