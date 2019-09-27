using BlogApp.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlogApp.Contracts
{
    public interface IArticleRepository
    {
        IEnumerable<Article> GetAll();

        IEnumerable<Article> GetArticlesForAuthor(Guid authorId);

        IEnumerable<Article> GetArticlesForAuthor(string authorEmail);

        Task<ILookup<Guid, Article>> GetArticlesByAuthorIds(IEnumerable<Guid> authorIds);
    }
}
