using MediatR;
using SmartPhonee.Application.Features.Mediator.Results.ImageResults;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartPhonee.Application.Features.Mediator.Queries.ImageQueries
{
    public class GetImageByIdQuery:IRequest<GetImageByIdQueryResult>
    {
        public int Id { get; set; }

        public GetImageByIdQuery(int id)
        {
            Id = id;
        }
    }
}
