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
    public class RemoveImageCommandHandler : IRequestHandler<RemoveImageCommand>
    {
        private readonly IRepository<Image> _repository;
        public RemoveImageCommandHandler(IRepository<Image> repository)
        {
            _repository = repository;
        }

        public async Task Handle(RemoveImageCommand request, CancellationToken cancellationToken)
        {
            var value = await _repository.GetByIdAsync(request.Id);
            await _repository.RemoveAsync(value);
        }
    }
}
