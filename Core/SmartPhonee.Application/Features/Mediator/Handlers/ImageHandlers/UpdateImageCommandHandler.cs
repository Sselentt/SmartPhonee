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
    public class UpdateImageCommandHandler : IRequestHandler<UpdateImageCommand>
    {
        private readonly IRepository<Image> _repository;
        public UpdateImageCommandHandler(IRepository<Image> repository)
        {
            _repository = repository;
        }

        public async Task Handle(UpdateImageCommand request, CancellationToken cancellationToken)
        {
            var values = await _repository.GetByIdAsync(request.ImageID);
            values.Image1Url= request.Image1Url;
            values.Image2Url = request.Image2Url;
            values.Image3Url = request.Image3Url;
            values.Image4Url = request.Image4Url;
            values.ProductID = request.ProductId;
            await _repository.UpdateAsync(values);
        }
    }
}
