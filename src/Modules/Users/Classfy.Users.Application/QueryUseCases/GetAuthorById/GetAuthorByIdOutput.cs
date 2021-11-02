using Classfy.Users.Domain.Author;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classfy.Users.Application.QueryUseCases.GetAuthorById
{
    public class GetAuthorByIdOutput
    {
        public GetAuthorByIdOutput(Author author)
        {
            Id = author.Id;
            Name = author.Name;
            Email = author.Email;
        }

        public Guid Id {  get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
    }
}
