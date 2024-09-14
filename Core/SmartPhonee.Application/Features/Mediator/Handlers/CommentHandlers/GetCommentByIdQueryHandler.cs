using MediatR;
using SmartPhonee.Application.Features.Mediator.Queries.CommentQueries;
using SmartPhonee.Application.Features.Mediator.Results.CategoryResults;
using SmartPhonee.Application.Features.Mediator.Results.CommentResults;
using SmartPhonee.Application.Interfaces;
using SmartPhonee.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartPhonee.Application.Features.Mediator.Handlers.CommentHandlers
{
    public class GetCommentByIdQueryHandler:IRequestHandler<GetCommentByIdQuery, GetCommentByIdQueryResult>
    {
        private readonly IRepository<Comment> _repository;
        public GetCommentByIdQueryHandler(IRepository<Comment> repository)
        {
            _repository = repository;
        }

        public async Task<GetCommentByIdQueryResult> Handle(GetCommentByIdQuery request, CancellationToken cancellationToken)
        {
            var values = await _repository.GetByIdAsync(request.Id);
            return new GetCommentByIdQueryResult
            {
                CommentID=values.CommentID,
                Rating=values.Rating,
                SendDate=values.SendDate,
                Description=values.Description,
                CustomerName=values.CustomerName,
                CustomerEmail=values.CustomerEmail,
                ProductId=values.ProductID,

            };
        }
    }
}
