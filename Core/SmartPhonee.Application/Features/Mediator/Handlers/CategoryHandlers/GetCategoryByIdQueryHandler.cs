using MediatR;
using SmartPhonee.Application.Features.Mediator.Queries.CategoryQueries;
using SmartPhonee.Application.Features.Mediator.Results.CategoryResults;
using SmartPhonee.Application.Interfaces;
using SmartPhonee.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartPhonee.Application.Features.Mediator.Handlers.CategoryHandlers
{
    public class GetCategoryByIdQueryHandler : IRequestHandler<GetCategoryByIdQuery, GetCategoryByIdQueryResult>
    {
        private readonly IRepository<Category> _repository;
        public GetCategoryByIdQueryHandler(IRepository<Category> repository)
        {
            _repository = repository;
        }

        public async Task<GetCategoryByIdQueryResult> Handle(GetCategoryByIdQuery request, CancellationToken cancellationToken)
        {
            var values = await _repository.GetByIdAsync(request.Id);
            return new GetCategoryByIdQueryResult
            {
                CategoryID=values.CategoryID,
                CategoryName=values.CategoryName,
            };
        }
    }
}
