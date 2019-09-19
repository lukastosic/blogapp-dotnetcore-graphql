using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BlogApp.Entities
{
    public class Tag
    {
        [Key]
        public string TagId { get; set; }

        public List<ArticleTag> ArticleTags { get; set; }
    }
}
