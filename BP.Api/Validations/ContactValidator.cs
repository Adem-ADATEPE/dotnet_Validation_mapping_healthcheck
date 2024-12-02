using BP.Api.Models;
using FluentValidation;

namespace BP.Api.Validations
{
    public class ContactValidator: AbstractValidator<ContactDVO>
    {
        public ContactValidator()
        {
            RuleFor(i => i.FullName).NotEmpty().WithMessage("isim soy isim boş olamaz.");
            RuleFor(x => x.Id).LessThan(100).WithMessage("Id 100 den büyük olamaz.");
        }
    }
}
