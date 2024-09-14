using MediatR;
using SmartPhonee.Application.Features.Mediator.Queries.CategoryQueries;
using SmartPhonee.Application.Features.Mediator.Queries.ProductQueries;
using SmartPhonee.Application.Features.Mediator.Results.CategoryResults;
using SmartPhonee.Application.Features.Mediator.Results.ProductResults;
using SmartPhonee.Application.Interfaces;
using SmartPhonee.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartPhonee.Application.Features.Mediator.Handlers.ProductHandlers
{
    public class GetProductQueryHandler : IRequestHandler<GetProductQuery, List<GetProductQueryResult>>
    {
        private readonly IRepository<Product> _repository;
        public GetProductQueryHandler(IRepository<Product> repository)
        {
            _repository = repository;
        }

        public async Task<List<GetProductQueryResult>> Handle(GetProductQuery request, CancellationToken cancellationToken)
        {
            var values = await _repository.GetAllAsync();
            return values.Select(x => new GetProductQueryResult
            {
                ProductID = x.ProductID,
                ProductName = x.ProductName,
                Price = x.Price,
                Description = x.Description,
                ImageUrl = x.ImageUrl,
                discountPercentage=x.discountPercentage,
                AvgRating=x.AvgRating,
                Stock=x.Stock,
                Tags=x.Tags,
                Brand=x.Brand,
                Sku=x.Sku,
                Weight=x.Weight,
                Width=x.Width,
                Height=x.Height,
                Depth=x.Depth,
                warrantyInformation=x.warrantyInformation,
                shippingInformation=x.shippingInformation,
                availabilityStatus=x.availabilityStatus,
                CategoryID=x.CategoryID,
                
            }).ToList();
        }
    }
}
