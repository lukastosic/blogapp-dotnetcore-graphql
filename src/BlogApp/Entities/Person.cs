using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

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

        public List<ArticleFavorite> ArticleFavorites { get; set; }

        public List<FollowedPerson> Following { get; set; }

        public List<FollowedPerson> Followers { get; set; }

        public List<Article> Articles { get; set; }

        public byte[] Hash { get; set; }

        public byte[] Salt { get; set; }

    }
}
