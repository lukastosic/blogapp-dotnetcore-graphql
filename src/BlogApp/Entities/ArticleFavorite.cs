using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace BlogApp.Entities
{
    public class ArticleFavorite
    {
        [ForeignKey("ArticleId")]
        public Guid ArticleId { get; set; }

        public Article Article { get; set; }

        [ForeignKey("PersonId")]
        public Guid PersonId { get; set; }

        public Person Person { get; set; }
    }
}
