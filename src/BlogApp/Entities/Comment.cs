using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace BlogApp.Entities
{
    public class Comment
    {
        [Key]
        public Guid Id { get; set; }

        [Required(ErrorMessage = "Comment cannot be empty")]
        public string Content { get; set; }

        [ForeignKey("AuthorId")]
        public Guid AuthorId { get; set; }

        public Person Author { get; set; }

        [ForeignKey("ArticleId")]
        public Guid ArticleId { get; set; }

        public Article Article { get; set; }

        public DateTime CreatedAt { get; set; }

        public DateTime UpdatedAt { get; set; }
    }
}
