using MediatR;
using SmartPhonee.Application.Features.Mediator.Queries.ProductQueries;
using SmartPhonee.Application.Features.Mediator.Results.ProductResults;
using SmartPhonee.Application.Interfaces.ProductInterface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartPhonee.Application.Features.Mediator.Handlers.ProductHandlers
{
    public class GetProductWithCategoryQueryHandler : IRequestHandler<GetProductWithCategoryQuery, List<GetProductWithCategoryQueryResult>>
    {
        private readonly IProductRepository _repository;
        public GetProductWithCategoryQueryHandler(IProductRepository repository)
        {
            _repository = repository;
        }


        public async Task<List<GetProductWithCategoryQueryResult>> Handle(GetProductWithCategoryQuery request, CancellationToken cancellationToken)
        {
            var values = _repository.GetProductsListWithCategory();
            return values.Select(x => new GetProductWithCategoryQueryResult
            {
                ProductID = x.ProductID,
                CategoryID = x.CategoryID,
                ImageID=x.ImageID,
                ProductName = x.ProductName,
                CategoryName = x.Category.CategoryName,
                Description = x.Description,
                Price = x.Price,
                ImageUrl = x.ImageUrl,
                discountPercentage = x.discountPercentage,
                AvgRating = x.AvgRating,
                Stock = x.Stock,
                Tags = x.Tags,
                Brand = x.Brand,
                Sku = x.Sku,
                Weight = x.Weight,
                Width = x.Width,
                Height = x.Height,
                Depth = x.Depth,
            }).ToList();
        }
    }
}
