using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classfy.Users.Application.QueryUseCases.GetAuthorById
{
    public class GetAuthorByIdInput : IRequest<GetAuthorByIdOutput?>
    {
        public GetAuthorByIdInput(Guid id)
        {
            Id = id;
        }

        public Guid Id { get; set; }
    }
}
