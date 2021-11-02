using Classfy.Users.Domain.Author;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classfy.Users.Infra.Persistence.EF.Repositories
{
    public class AuthorRepository : IAuthorRepository
    {
        private readonly ClassfyUsersDbContext _dbContext;

        public AuthorRepository(ClassfyUsersDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<Author?> GetById(Guid id)
        {
            return await _dbContext.Authors.SingleOrDefaultAsync(author => author.Id == id);
        }

        public async Task<Author> Create(Author author)
        {
            await _dbContext.Authors.AddAsync(author);
            await _dbContext.SaveChangesAsync();
            return author;
        }

        public async Task<IEnumerable<AuthorSummaryItemDTO>> GetAllAuthorsSummary()
        {
            return await _dbContext.Authors
                .Select(
                    author => new AuthorSummaryItemDTO(author.Id, author.Name)
                ).ToListAsync();
        }
    }
}
