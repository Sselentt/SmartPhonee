using MediatR;
using SmartPhonee.Application.Features.Mediator.Queries.CommentQueries;
using SmartPhonee.Application.Features.Mediator.Queries.ImageQueries;
using SmartPhonee.Application.Features.Mediator.Results.CommentResults;
using SmartPhonee.Application.Features.Mediator.Results.ImageResults;
using SmartPhonee.Application.Interfaces;
using SmartPhonee.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartPhonee.Application.Features.Mediator.Handlers.ImageHandlers
{
    public class GetImageByIdQueryHandler : IRequestHandler<GetImageByIdQuery, GetImageByIdQueryResult>
    {
        private readonly IRepository<Image> _repository;
        public GetImageByIdQueryHandler(IRepository<Image> repository)
        {
            _repository = repository;
        }

        public async Task<GetImageByIdQueryResult> Handle(GetImageByIdQuery request, CancellationToken cancellationToken)
        {
            var values = await _repository.GetByIdAsync(request.Id);
            return new GetImageByIdQueryResult
            {
                ImageID=values.ImageID,
                Image1Url=values.Image1Url,
                Image2Url=values.Image2Url,
                Image3Url=values.Image3Url,
                Image4Url=values.Image4Url,
                ProductId=values.ProductID,

            };
        }
    }
}
