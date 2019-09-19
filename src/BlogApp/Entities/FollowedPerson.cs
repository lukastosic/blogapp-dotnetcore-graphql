using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace BlogApp.Entities
{
    public class FollowedPerson
    {
        [ForeignKey("FollowerId")]
        public Guid FollowerId { get; set; }

        public Person Follower { get; set; }

        [ForeignKey("FollowedId")]
        public Guid FollowedId { get; set; }

        public Person Followed { get; set; }
    }
}
