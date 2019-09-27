using BlogApp.Contracts;
using BlogApp.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlogApp.Repository
{
    public class ArticleRepository : IArticleRepository
    {
        private readonly DatabaseContext dbContext;

        public ArticleRepository(DatabaseContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public IEnumerable<Article> GetAll()
        {
            return dbContext.Articles.Include(x => x.Author);
        }

        public async Task<ILookup<Guid, Article>> GetArticlesByAuthorIds(IEnumerable<Guid> authorIds)
        {
            var articles = await dbContext.Articles.Where(a => authorIds.Contains(a.AuthorId)).ToListAsync();
            return articles.ToLookup(a => a.AuthorId);
        }

        public IEnumerable<Article> GetArticlesForAuthor(Guid authorId)
        {
            return dbContext.Articles.Where(a => a.AuthorId.Equals(authorId)).ToList();
        }

        public IEnumerable<Article> GetArticlesForAuthor(string authorEmail)
        {
            return dbContext.Articles.Include(a=>a.Author).Where(a => a.Author.Email.Equals(authorEmail)).ToList();
        }
    }
}
