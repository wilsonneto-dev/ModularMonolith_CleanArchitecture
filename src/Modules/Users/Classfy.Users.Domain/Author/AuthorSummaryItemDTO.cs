using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classfy.Users.Domain.Author
{
    public class AuthorSummaryItemDTO
    {
        public AuthorSummaryItemDTO(Guid id, string name)
        {
            Id = id;
            Name = name;
        }

        public Guid Id { get; set; }
        public string Name { get; set; }
    }
}
