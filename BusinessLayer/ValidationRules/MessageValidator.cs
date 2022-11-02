using EntityLayer.Concrete;
using FluentValidation;
namespace BusinessLayer.ValidationRules
{
    public class MessageValidator : AbstractValidator<Message>
    {
        public MessageValidator()
        {
            RuleFor(x => x.ReceiverMail).NotEmpty().WithMessage("Lütfen Alıcı adresini boş Geçmeyiniz");
            RuleFor(x => x.Subject).NotEmpty().WithMessage("Lütfen Konuyu boş Geçmeyiniz");
            RuleFor(x => x.MessageContent).NotEmpty().WithMessage("Mesajı boş Geçmeyiniz");
            RuleFor(x => x.Subject).MinimumLength(3).WithMessage("Lütfen en az 3 karakter girişi yapınız");
            RuleFor(x => x.Subject).MaximumLength(50).WithMessage("Lütfen 100 karakterden fazla değer girişi yapmayınız");
        }
    }
}
