using EntityLayer.Concrete;
using FluentValidation;

namespace BusinessLayer.ValidationRules
{
    public class SkillValidator : AbstractValidator<Skill>
    {
        public SkillValidator()
        {
            RuleFor(x => x.SkillName).NotEmpty().WithMessage("Lütfen Yetenek İsmi Boş Bırakılamaz");
            RuleFor(x => x.SkillName).MaximumLength(50).WithMessage("Lütfen Yetenek İsmi En Fazla 50 Karekterden Oluşabilir");
            RuleFor(x => x.SkillName).MinimumLength(1).WithMessage("Lütfen Yetenek İsmi En Az 3 Karekterden Oluşabilir");
            RuleFor(x => x.SkillValue).NotEmpty().WithMessage("Lütfen Yetenek Değeri Boş Bırakılamaz");
            RuleFor(x => x.SkillValue).LessThanOrEqualTo(100).WithMessage("Lütfen Yetenek Değeri En Fazla 100 Olabilir");
            RuleFor(x => x.SkillValue).GreaterThan(0).WithMessage("Lütfen Yetenek Değeri En Az 0 Olabilir");
        }
    }
}
