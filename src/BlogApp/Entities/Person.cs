using System;
using System.ComponentModel.DataAnnotations;

namespace BlogApp.Entities
{
    public class Person
    {
        [Key]
        public Guid Id { get; set; }
        
        public string Username { get; set; }

        public string Email { get; set; }

        public string About { get; set; }

        public string Name { get; set; }

        public string LastName { get; set; }

        public string Image { get; set;}

        public PersonRank Rank { get; set; }

    }
}
