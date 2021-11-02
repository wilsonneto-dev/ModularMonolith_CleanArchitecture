using Classfy.Users.Domain.Author;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classfy.Users.Application.CommandUseCases.CreateAuthor
{
    public class CreateAuthorUseCase : IRequestHandler<CreateAuthorInput, Guid>
    {
        private readonly IAuthorRepository _authorRepository;
        public CreateAuthorUseCase(IAuthorRepository authorRepository)
        {
            _authorRepository = authorRepository;
        }

        public async Task<Guid> Handle(CreateAuthorInput command, CancellationToken cancellationToken)
        {
            Author author = new Author(command.Name, command.Email, command.Password);
            await _authorRepository.Create(author);
            return author.Id;
        }
    }
}
