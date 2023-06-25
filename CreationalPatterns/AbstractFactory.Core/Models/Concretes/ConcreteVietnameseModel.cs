using AbstractFactory.Core.Models.Abstracts;

namespace AbstractFactory.Core.Models.Concretes;

public class ConcreteVietnameseModel : AbstractLanguageModel
{
    public override string Hello { get; set; } = "Xin chào";
}