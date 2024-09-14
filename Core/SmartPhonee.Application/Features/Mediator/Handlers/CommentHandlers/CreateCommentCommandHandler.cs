using MediatR;
using SmartPhonee.Application.Features.Mediator.Commands.CommentCommands;
using SmartPhonee.Application.Interfaces;
using SmartPhonee.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartPhonee.Application.Features.Mediator.Handlers.CommentHandlers
{
    public class CreateCommentCommandHandler:IRequestHandler<CreateCommentCommand>
    {
        private readonly IRepository<Comment> _repository;
        public CreateCommentCommandHandler(IRepository<Comment> repository)
        {
            _repository = repository;
        }

        public async Task Handle(CreateCommentCommand request, CancellationToken cancellationToken)
        {
            await _repository.CreateAsync(new Comment
            {
                Rating = request.Rating,
                Description = request.Description,
                SendDate = request.SendDate,
                CustomerName = request.CustomerName,
                CustomerEmail = request.CustomerEmail,
                ProductID=request.ProductId,
            });
        }
    }
}
