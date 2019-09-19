using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace BlogApp.Entities
{
    public class ArticleTag
    {
        [ForeignKey("ArticleId")]
        public Guid ArticleId { get; set; }

        public Article Article { get; set; }

        [ForeignKey("TagId")]
        public string TagId { get; set; }
        public Tag Tag { get; set; }

    }
}
