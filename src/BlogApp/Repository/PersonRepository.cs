using BlogApp.Contracts;
using BlogApp.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlogApp.Repository
{
    public class PersonRepository : IPersonRepository
    {
        private readonly DatabaseContext dbContext;

        public PersonRepository(DatabaseContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public IEnumerable<Person> GetAll()
        {
            return this.dbContext.People.ToList();
        }

        public Person GetById(Guid id)
        {
            return dbContext.People.SingleOrDefault(p => p.Id.Equals(id));
        }

        public Person GetByEmail(string email)
        {
            return dbContext.People.SingleOrDefault(p => p.Email.Equals(email));
        }

        public Person CreatePerson(Person person)
        {
            person.Id = Guid.NewGuid();
            dbContext.Add(person);
            dbContext.SaveChanges();
            return person;
        }
    }
}
