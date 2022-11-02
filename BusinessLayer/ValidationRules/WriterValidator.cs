using EntityLayer.Concrete;
using FluentValidation;

namespace BusinessLayer.ValidationRules
{
    public class WriterValidator : AbstractValidator<Writer>
    {
        public WriterValidator()
        {
            RuleFor(x => x.WriterName).NotEmpty().WithMessage("Lütfen Yazar adını boş Geçmeyiniz");
            RuleFor(x => x.WriterSurName).NotEmpty().WithMessage("Lütfen Yazar soyadını boş Geçmeyiniz");
            RuleFor(x => x.WriterAbout).NotEmpty().WithMessage("Lütfen Hakkımda kısmını boş Geçmeyiniz");
            RuleFor(x => x.WriterTitle).NotEmpty().WithMessage("Lütfen Ünvan kısmını boş Geçmeyiniz");
            RuleFor(x => x.WriterSurName).MinimumLength(3).WithMessage("Lütfen en az 2 karakter girişi yapınız");
            RuleFor(x => x.WriterSurName).MaximumLength(50).WithMessage("Lütfen 50 karakterden fazla değer girişi yapmayınız");
        }
    }
}
