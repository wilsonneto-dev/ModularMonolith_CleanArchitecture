using AutoMapper;
using Classfy.Users.Domain.Author;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classfy.Users.Application.QueryUseCases.GetAuthorById
{
    public class GetAuthorByIdUseCase : IRequestHandler<GetAuthorByIdInput, GetAuthorByIdOutput?>
    {
        private readonly IAuthorRepository _authorRepository;
        private readonly IMapper _mapper;

        public GetAuthorByIdUseCase(IAuthorRepository authorRepository, IMapper mapper)
        {
            _authorRepository = authorRepository;
            _mapper = mapper;
        }

        public async Task<GetAuthorByIdOutput?> Handle(GetAuthorByIdInput request, CancellationToken cancellationToken)
        {
            Author? author = await _authorRepository.GetById(request.Id);
            if (author == null)
                return null;
            return new GetAuthorByIdOutput(author);
        }
    }
}
