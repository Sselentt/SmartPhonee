using MediatR;
using SmartPhonee.Application.Features.Mediator.Results.CategoryResults;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartPhonee.Application.Features.Mediator.Queries.CategoryQueries
{
    public class GetCategoryQuery:IRequest<List<GetCategoryQueryResult>>
    {

    }
}
