using MediatR;
using SmartPhonee.Application.Features.Mediator.Results.ProductResults;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartPhonee.Application.Features.Mediator.Queries.ProductQueries
{
    public class GetProductWithCategoryQuery : IRequest<List<GetProductWithCategoryQueryResult>>
    {
    }
}
