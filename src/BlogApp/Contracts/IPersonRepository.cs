using BlogApp.Entities;
using System;
using System.Collections.Generic;

namespace BlogApp.Contracts
{
    public interface IPersonRepository
    {
        IEnumerable<Person> GetAll();

        Person GetById(Guid id);

        Person GetByEmail(string email);

        Person CreatePerson(Person person);
    }
}
