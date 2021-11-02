using Classfy.Unified.API.Shared.ViewModel;
using Classfy.Users.Application.CommandUseCases.CreateAuthor;
using Classfy.Users.Application.QueryUseCases.GetAuthorById;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace Classfy.Unified.API.Users.Controllers
{
    [Route("/authors")]
    public class AuthorsController : ControllerBase
    {
        private readonly IMediator _mediator;
        public AuthorsController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpPost]
        [ProducesResponseType(typeof(IdViewModel), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> Create([FromBody] CreateAuthorInput command)
        {
            Guid createdAuthorId = await _mediator.Send(command);
            return CreatedAtAction(null, new IdViewModel(createdAuthorId), command);
        }

        [HttpGet("{id}")]
        [ProducesResponseType(typeof(GetAuthorByIdOutput), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> GetById([FromRoute] Guid id)
        {
            GetAuthorByIdInput query = new GetAuthorByIdInput(id);
            GetAuthorByIdOutput? authorInformation = await _mediator.Send(query);
            if (authorInformation == null)
                return NotFound();
            return Ok(authorInformation);
        }
    }
}
