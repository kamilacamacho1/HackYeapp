using FluentValidation.Results;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aplication.Exceptions
{
    public class ValidationException : Exception
    {
        public ValidationException(): base("Se ha producido un error de validación")        
        {
            Errors = new List<string>();
        }
        public List<string> Errors { get; set; }

        public ValidationException(IEnumerable<ValidationFailure> failures) : this()
        {
            foreach (var failure in failures)
            {
                Errors.Add(failure.ErrorMessage);

            }

        }
    }
}
