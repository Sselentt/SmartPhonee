using Microsoft.EntityFrameworkCore;
using SmartPhonee.Application.Interfaces.ProductInterface;
using SmartPhonee.Domain.Entities;
using SmartPhonee.Persistance.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartPhonee.Persistance.Repositories.ProductRepository
{
    public class ProductRepository:IProductRepository
    {
        private readonly SmartPhoneeContext _context;

        public ProductRepository(SmartPhoneeContext context)
        {
            _context = context;
        }

        public List<Product> GetProductsListWithCategory()
        {
            var values = _context.Products.Include(x => x.Category).ToList();
            foreach (var product in values)
            {
                Console.WriteLine($"Product Name: {product.ProductID}, Category: {product.Category.CategoryName}");
            }

            return values;
        }
    }
}
