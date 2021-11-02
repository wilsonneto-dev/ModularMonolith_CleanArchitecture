using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classfy.Users.Application.CommandUseCases.CreateAuthor
{
    public class CreateAuthorInputValidator : AbstractValidator<CreateAuthorInput>
    {
        public CreateAuthorInputValidator()
        {
            RuleFor(c => c.Email)
                .EmailAddress()
                .WithMessage("E-mail address expected");
        }
    }
}
