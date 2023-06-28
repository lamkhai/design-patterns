using AbstractFactory.Core.Models.Abstracts;
using LK.Shared.Constants;

namespace AbstractFactory.Core.Models.Concretes;

public class ConcreteEnglandModel : AbstractCountryModel
{
    public override string Capital { get; set; } = CapitalConstants.London;

    public override string Name { get; set; } = CountryConstants.England;
}