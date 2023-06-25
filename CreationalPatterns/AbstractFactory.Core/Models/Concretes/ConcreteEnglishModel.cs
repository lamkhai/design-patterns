using AbstractFactory.Core.Models.Abstracts;

namespace AbstractFactory.Core.Models.Concretes;

public class ConcreteEnglishModel : AbstractLanguageModel
{
    public override string Hello { get; set; } = "Hello";
}