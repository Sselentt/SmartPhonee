using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SmartPhonee.Application.Features.Mediator.Commands.CategoryCommands;
using SmartPhonee.Application.Features.Mediator.Commands.ImageCommands;
using SmartPhonee.Application.Features.Mediator.Queries.CategoryQueries;
using SmartPhonee.Application.Features.Mediator.Queries.ImageQueries;

namespace SmartPhonee.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ImagesController : ControllerBase
    {
        private readonly IMediator _mediator;
        public ImagesController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<IActionResult> ImageList()
        {
            var values = await _mediator.Send(new GetImageQuery());
            return Ok(values);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetImage(int id)
        {
            var value = await _mediator.Send(new GetImageByIdQuery(id));
            return Ok(value);
        }

        [HttpPost]
        public async Task<IActionResult> CreateImage(CreateImageCommand command)
        {
            await _mediator.Send(command);
            return Ok("Resim Başarıyla Eklendi");
        }

        [HttpDelete]
        public async Task<IActionResult> RemoveImage(int id)
        {
            await _mediator.Send(new RemoveImageCommand(id));
            return Ok("Resim Başarıyla Silindi!");
        }

        [HttpPut]
        public async Task<IActionResult> UpdateImage(UpdateImageCommand command)
        {
            await _mediator.Send(command);
            return Ok("Resim Başarıyla Güncellendi");
        }
    }
}
