﻿using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartPhonee.Application.Features.Mediator.Commands.CategoryCommands
{
    public class CreateCategoryCommand:IRequest
    {
        public string CategoryName { get; set; }
    }
}
