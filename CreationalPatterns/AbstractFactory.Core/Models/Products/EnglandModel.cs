using AbstractFactory.Core.Models.ProductAbstracts;
using LK.Shared.Constants;

namespace AbstractFactory.Core.Models.Products;

public class EnglandModel : Country
{
    public override string Capital { get; set; } = CapitalConstants.London;

    public override string Name { get; set; } = CountryConstants.England;
}