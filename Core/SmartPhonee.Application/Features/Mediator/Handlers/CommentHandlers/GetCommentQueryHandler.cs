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
    public class GetCommentQueryHandler:IRequestHandler<GetCommentQuery, List<GetCommentQueryResult>>
    {
        private readonly IRepository<Comment> _repository;
        public GetCommentQueryHandler(IRepository<Comment> repository)
        {
            _repository = repository;
        }

        public async Task<List<GetCommentQueryResult>> Handle(GetCommentQuery request, CancellationToken cancellationToken)
        {
            var values = await _repository.GetAllAsync();
            return values.Select(x => new GetCommentQueryResult
            {
                CommentID = x.CommentID,
                Rating = x.Rating,
                SendDate = x.SendDate,
                Description = x.Description,
                CustomerName = x.CustomerName,
                CustomerEmail = x.CustomerEmail,
                ProductId=x.ProductID,
            }).ToList();
        }
    }
}
