using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
    class ContactValidator : AbstractValidator<Contact>
    {
        public ContactValidator()
        {
            RuleFor(x => x.UserName).NotEmpty().WithMessage("Kullanıcı adı girmelisiniz.");
            RuleFor(x => x.UserMail).NotEmpty().WithMessage("Mail adresi girmelisiniz.");
            RuleFor(x => x.Subject).NotEmpty().WithMessage("Konu başlığı girmelisiniz.");
            RuleFor(x => x.Subject).MinimumLength(3).WithMessage("Konu başlığı min. 3 karakterden oluşmalıdır.");
            RuleFor(x => x.Subject).MaximumLength(50).WithMessage("Konu başlığı max. 50 karakterden oluşmalıdır.");
            RuleFor(x => x.Message).NotEmpty().WithMessage("Mesajınızı girmelisiniz.");

        }
    }
}
