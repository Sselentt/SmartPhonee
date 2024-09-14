using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartPhonee.Application.Features.Mediator.Commands.ImageCommands
{
    public class RemoveImageCommand : IRequest
    {
        public int Id { get; set; }

        public RemoveImageCommand(int id)
        {
            Id = id;
        }
    }
}
