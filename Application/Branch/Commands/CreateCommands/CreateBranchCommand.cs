
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Branch.Commands.CreateCommands;

    public class CreateBranchCommand :IRequest<Result>
    {
        public string Name { get; set; }
    }
    // ===== Method Handler =========
    //public class CreateBranchCommandHandler : IRequestHandler<CreateBranchCommand, Result>
    //{}