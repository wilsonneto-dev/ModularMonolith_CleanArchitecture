using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classfy.Users.Domain.Author
{
    public interface IAuthorRepository
    {
        Task<Author?> GetById(Guid id);
        Task<Author> Create(Author author);
        Task<IEnumerable<AuthorSummaryItemDTO>> GetAllAuthorsSummary();
    }
}
