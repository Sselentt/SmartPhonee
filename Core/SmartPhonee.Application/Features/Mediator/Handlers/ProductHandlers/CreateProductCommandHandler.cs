using MediatR;
using SmartPhonee.Application.Features.Mediator.Commands.CategoryCommands;
using SmartPhonee.Application.Features.Mediator.Commands.ProductCommands;
using SmartPhonee.Application.Interfaces;
using SmartPhonee.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartPhonee.Application.Features.Mediator.Handlers.ProductHandlers
{
    public class CreateProductCommandHandler : IRequestHandler<CreateProductCommand>
    {
        private readonly IRepository<Product> _repository;
        public CreateProductCommandHandler(IRepository<Product> repository)
        {
            _repository = repository;
        }

        public async Task Handle(CreateProductCommand request, CancellationToken cancellationToken)
        {
            await _repository.CreateAsync(new Product
            {
                ProductName = request.ProductName,
                Description = request.Description,
                Price = request.Price,
                ImageUrl = request.ImageUrl,
                discountPercentage=request.discountPercentage,
                AvgRating=request.AvgRating,
                Stock=request.Stock,
                Tags=request.Tags,
                Brand=request.Brand,
                Sku=request.Sku,
                Weight=request.Weight,
                Width=request.Width,
                Height=request.Height,
                Depth=request.Depth,
                warrantyInformation=request.warrantyInformation,
                shippingInformation=request.shippingInformation,
                availabilityStatus=request.availabilityStatus,
                CategoryID=request.CategoryId,
                
            });
        }
    }
}
