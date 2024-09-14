using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartPhonee.Application.Features.Mediator.Commands.CommentCommands
{
    public class CreateCommentCommand : IRequest
    {
        public double Rating { get; set; }
        public string Description { get; set; }
        public DateTime SendDate { get; set; }
        public string CustomerName { get; set; }
        public string CustomerEmail { get; set; }
        public int ProductId { get; set; }
    }
}
