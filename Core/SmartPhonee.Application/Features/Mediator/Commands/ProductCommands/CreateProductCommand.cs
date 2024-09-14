using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartPhonee.Application.Features.Mediator.Commands.ProductCommands
{
    public class CreateProductCommand : IRequest
    {
        public string ProductName { get; set; }
        public string Description { get; set; }
        public double Price { get; set; }
        public string ImageUrl { get; set; }
        public double discountPercentage { get; set; }
        public double AvgRating { get; set; }
        public int Stock { get; set; }
        public string Tags { get; set; }
        public string Brand { get; set; }
        public string Sku { get; set; }
        public double Weight { get; set; }
        public double Width { get; set; }
        public double Height { get; set; }
        public double Depth { get; set; }
        public string warrantyInformation { get; set; }
        public string shippingInformation { get; set; }
        public bool availabilityStatus { get; set; }
        public int CategoryId { get; set; }
    }
}
