using AbstractFactory.Core.Models.Abstracts;

namespace AbstractFactory.Core.Models.Concretes;

public class ConcreteEnglandModel : AbstractCountryModel
{
    public override string Capital { get; set; } = "London";

    public override string Name { get; set; } = "England";
}