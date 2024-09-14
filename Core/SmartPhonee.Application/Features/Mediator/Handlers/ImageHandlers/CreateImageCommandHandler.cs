using MediatR;
using SmartPhonee.Application.Features.Mediator.Commands.CommentCommands;
using SmartPhonee.Application.Features.Mediator.Commands.ImageCommands;
using SmartPhonee.Application.Interfaces;
using SmartPhonee.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartPhonee.Application.Features.Mediator.Handlers.ImageHandlers
{
    public class CreateImageCommandHandler : IRequestHandler<CreateImageCommand>
    {
        private readonly IRepository<Image> _repository;
        public CreateImageCommandHandler(IRepository<Image> repository)
        {
            _repository = repository;
        }

        public async Task Handle(CreateImageCommand request, CancellationToken cancellationToken)
        {
            await _repository.CreateAsync(new Image
            {
                Image1Url = request.Image1Url,
                Image2Url = request.Image2Url,
                Image3Url = request.Image3Url,
                Image4Url = request.Image4Url,
                ProductID=request.ProductId,
            });
        }
    }
}
