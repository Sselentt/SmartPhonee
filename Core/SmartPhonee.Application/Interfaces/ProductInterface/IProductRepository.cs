using SmartPhonee.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace SmartPhonee.Application.Interfaces.ProductInterface
{
    public interface IProductRepository
    {
        List<Product> GetProductsListWithCategory();
       

      
        
    }
}
