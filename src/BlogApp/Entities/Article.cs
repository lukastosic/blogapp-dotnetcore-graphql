using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace BlogApp.Entities
{
    public class Article
    {
        [Key]
        public Guid Id { get; set; }

        [Required(ErrorMessage = "Slug is required")]
        public string Slug { get; set; }

        [Required(ErrorMessage ="Title is required")]
        public string Title { get; set; }
        
        public string Description { get; set; }

        [Required(ErrorMessage = "Content is required")]
        public string Content { get; set; }
        
        [ForeignKey("AuthorId")]
        public Guid AuthorId { get; set; }

        public Person Author { get; set; }

        public DateTime CreatedAt { get; set; }

        public DateTime UpdatedAt { get; set; }

        public List<Comment> Comments { get; set; }

        public List<ArticleTag> ArticleTags { get; set; }

        public List<ArticleFavorite> FavoritedBy { get; set; }

        [NotMapped]
        public List<string> TagList => (ArticleTags?.Select(x=>x.TagId) ?? Enumerable.Empty<string>()).ToList();

        [NotMapped]
        public int FavoritesCount => FavoritedBy?.Count ?? 0;
    }
}
