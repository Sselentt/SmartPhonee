using MediatR;
using SmartPhonee.Application.Features.Mediator.Results.CommentResults;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartPhonee.Application.Features.Mediator.Queries.CommentQueries
{
    public class GetCommentQuery:IRequest<List<GetCommentQueryResult>>
    {
    }
}
