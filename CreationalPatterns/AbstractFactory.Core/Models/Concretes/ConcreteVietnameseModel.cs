using AbstractFactory.Core.Models.Abstracts;
using LK.Shared.Constants;

namespace AbstractFactory.Core.Models.Concretes;

public class ConcreteVietnameseModel : AbstractLanguageModel
{
    public override string Hello { get; set; } = LanguageConstants.Hello_Vietnamese;
}