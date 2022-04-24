using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aplication.Feactures.Cultivo.Commands.CreateCultivoCommand
{
    public class CreateCultivoCommandValidator : AbstractValidator<CreateCultivoCommand>
    {
        public CreateCultivoCommandValidator()
        {
            RuleFor(p => p.Nombre)
                .NotEmpty().WithMessage("No puede ser vacio")
                .MaximumLength(50);

            RuleFor(p => p.Descripcion)
                .NotEmpty()
                .MaximumLength(80);
        }
    }
}
