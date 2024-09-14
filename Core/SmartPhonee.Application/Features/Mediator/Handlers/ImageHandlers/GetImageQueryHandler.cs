using MediatR;
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
    public class GetImageQueryHandler : IRequestHandler<GetImageQuery, List<GetImageQueryResult>>
    {
        private readonly IRepository<Image> _repository;
        public GetImageQueryHandler(IRepository<Image> repository)
        {
            _repository = repository;
        }

        public async Task<List<GetImageQueryResult>> Handle(GetImageQuery request, CancellationToken cancellationToken)
        {
            var values = await _repository.GetAllAsync();
            return values.Select(x => new GetImageQueryResult
            {
                ImageID = x.ImageID,
                Image1Url = x.Image1Url,
                Image2Url = x.Image2Url,
                Image3Url = x.Image3Url,
                Image4Url = x.Image4Url,
                ProductId = x.ProductID,
            }).ToList();
        }
    }
}
