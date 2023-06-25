using AbstractFactory.Core.Models.Abstracts;

namespace AbstractFactory.Core.Models.Concretes;

public class ConcreteVietnamModel : AbstractCountryModel
{
    public override string Capital { get; set; } = "Hanoi";

    public override string Name { get; set; } = "Vietnam";
}