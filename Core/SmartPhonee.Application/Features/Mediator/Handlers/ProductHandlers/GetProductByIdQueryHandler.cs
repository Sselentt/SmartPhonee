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
    public class GetProductByIdQueryHandler : IRequestHandler<GetProductByIdQuery, GetProductByIdQueryResult>
    {
        private readonly IRepository<Product> _repository;
        public GetProductByIdQueryHandler(IRepository<Product> repository)
        {
            _repository = repository;
        }

        public async Task<GetProductByIdQueryResult> Handle(GetProductByIdQuery request, CancellationToken cancellationToken)
        {
            var values = await _repository.GetByIdAsync(request.Id);
            return new GetProductByIdQueryResult
            {
                ProductID=values.ProductID,
                ProductName=values.ProductName,
                Price=values.Price,
                Description=values.Description,
                ImageUrl=values.ImageUrl,
                discountPercentage=values.discountPercentage,
                AvgRating=values.AvgRating,
                Stock=values.Stock,
                Tags=values .Tags,
                Brand=values .Brand,
                Sku=values .Sku,
                Weight=values .Weight,
                Width=values .Width,
                Height=values .Height,
                Depth=values .Depth,
                warrantyInformation=values .warrantyInformation,
                shippingInformation=values .shippingInformation,
                availabilityStatus=values.availabilityStatus,
                CategoryId=values .CategoryID,
                ImageId=values.ImageID,
                
               
            };
        }
    }
}
