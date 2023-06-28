using AbstractFactory.Core.Models.Abstracts;
using LK.Shared.Constants;

namespace AbstractFactory.Core.Models.Concretes;

public class ConcreteVietnamModel : AbstractCountryModel
{
    public override string Capital { get; set; } = CapitalConstants.Hanoi;

    public override string Name { get; set; } = CountryConstants.Vietnam;
}