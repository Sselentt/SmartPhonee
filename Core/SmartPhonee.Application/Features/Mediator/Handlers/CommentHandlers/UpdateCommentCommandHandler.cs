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
    public class UpdateCommentCommandHandler:IRequestHandler<UpdateCommentCommand>
    {
        private readonly IRepository<Comment> _repository;
        public UpdateCommentCommandHandler(IRepository<Comment> repository)
        {
            _repository = repository;
        }

        public async Task Handle(UpdateCommentCommand request, CancellationToken cancellationToken)
        {
            var values = await _repository.GetByIdAsync(request.CommentID);
            values.Rating = request.Rating;
            values.Description = request.Description;
            values.SendDate = request.SendDate;
            values.CustomerName = request.CustomerName;
            values.CustomerEmail = request.CustomerEmail;
            values.ProductID = request.ProductId;
            await _repository.UpdateAsync(values);
        }
    }
}
