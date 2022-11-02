using EntityLayer.Concrete;
using FluentValidation;

namespace BusinessLayer.ValidationRules
{
    public class ContactValidator : AbstractValidator<Contact>
    {
        public ContactValidator()
        {
            RuleFor(x => x.UserMail).NotEmpty().WithMessage("Lütfen Mail adresini boş Geçmeyiniz");
            RuleFor(x => x.Subject).NotEmpty().WithMessage("Lütfen Konu Adını Boş Geçmeyiniz");
            RuleFor(x => x.UserName).NotEmpty().WithMessage("Lütfen Kullanıcı adını boş Geçmeyiniz");
            RuleFor(x => x.Subject).MinimumLength(3).WithMessage("Lütfen en az 3 karakter girişi yapınız");
            RuleFor(x => x.UserName).MinimumLength(3).WithMessage("Lütfen en az 3 karakter girişi yapınız");
            RuleFor(x => x.Subject).MaximumLength(50).WithMessage("Lütfen 50 karakterden fazla değer girişi yapmayınız");
        }
    }
}
