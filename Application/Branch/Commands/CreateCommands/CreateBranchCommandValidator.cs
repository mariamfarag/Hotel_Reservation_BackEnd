

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Application.Branch.Commands.CreateCommands
{
    public class CreateBranchCommandValidator : AbstractValidator<CreateBranchCommand>
    {
        public CreateBranchCommandValidator()
        {
            RuleFor(x => x.Name)
                .NotEmpty()
                .NotNull()
                .WithMessage("Please Enter Branch Name Required....")
                .MaximumLength(Consts.EntityLongNameLength).WithMessage($"Name Should be greater than { Consts.EntityLongNameLength}character")
                .MinimumLength(Consts.EntityMinNameLenght).WithMessage($"Name Should be less than {Consts.EntityMinNameLenght} character") ;
        }
    }
}
