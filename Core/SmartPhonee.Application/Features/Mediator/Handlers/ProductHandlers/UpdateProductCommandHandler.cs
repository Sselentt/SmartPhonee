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
    public class UpdateProductCommandHandler : IRequestHandler<UpdateProductCommand>
    {
        private readonly IRepository<Product> _repository;
        public UpdateProductCommandHandler(IRepository<Product> repository)
        {
            _repository = repository;
        }

        public async Task Handle(UpdateProductCommand request, CancellationToken cancellationToken)
        {
            var values = await _repository.GetByIdAsync(request.ProductID);
            values.ProductName  = request.ProductName;
            values.Price = request.Price;
            values.Description = request.Description;
            values.ImageUrl = request.ImageUrl;
            values.discountPercentage = request.discountPercentage;
            values.AvgRating = request.AvgRating;
            values.Stock= request.Stock;
            values.Tags = request.Tags;
            values.Brand = request.Brand;
            values.Sku  = request.Sku;
            values.Weight = request.Weight;
            values.Width = request.Width;
            values.Height = request.Height;
            values.Depth = request.Depth;
            values.warrantyInformation = request.warrantyInformation;
            values.shippingInformation = request.shippingInformation;
            values.availabilityStatus = request.availabilityStatus;
            values.CategoryID = request.CategoryId;
            values.ImageID = request.ImageId;
            await _repository.UpdateAsync(values);
        }
    }
}
